using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
    {
        /// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
        {
            InitializeComponent();

		}

        /// <summary>
		/// メイン処理
		/// </summary>
		static void Main()
        {
            Application.Run(new Form1());
		}

		#region イベント

		/// <summary>
		/// フォーム初期表示イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			Clear();
		}

		/// <summary>
		/// クリアボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void clearButton_Click(object sender, EventArgs e)
		{
			Clear();
		}

		/// <summary>
		/// 計算ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void calculationButtons_click(object sender, EventArgs e)
		{
			// テキストボックスの入力値を取り出す
			string batsVal = batsText.Text;
			string hitsVal = hitsText.Text;

			// 1.入力チェックを行う

			// 入力チェック結果を取得
			string message = InputCheck(batsVal, hitsVal);

			if (!string.IsNullOrEmpty(message))
			{
				// ⇒入力チェックの結果、エラーがあればメッセージをダイアログに出して処理終了
				MessageBox.Show(message);
				return;
			}

			//⇒入力チェックの結果、エラーが無ければ1 - 5へ


			//1 - 5.打数判定
			if ("0".Equals(batsVal))
			{
				//	打数がゼロの場合：			
				//		(打率計算を行わずに)打率表示テキストボックスに「"ー"」を表示する
				averageText.Text = "-";
			}
			else
			{
                //	打数がゼロ以外の場合：			
                //		2 - 1の打率計算を実施

                // 計算結果を小数値(double)で取得するため、打数と安打数をdouble型に変換
                // ※ 1 - 2.正の整数チェックが終わっているのでdouble.Parseがエラーになる心配がない
                double batsDoubleVal = double.Parse(batsVal);
                double hitsDoubleVal = double.Parse(hitsVal);

                // 2.打率計算を行う
                double averageVal = CalcAverage(batsDoubleVal, hitsDoubleVal);

				// 3.計算結果を表示
				averageText.Text = FormatAverage(averageVal);
			}
		}

		/// <summary>
		/// 終了ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void endButton_Click(object sender, EventArgs e)
		{
			// フォームを閉じる
			this.Close();
		}

		#endregion

		#region privateメソッド

		/// <summary>
		/// フォーム内容初期化
		/// </summary>
		private void Clear()
		{
			batsText.Text = "0";
			hitsText.Text = "0";
			averageText.Text = "";
		}

		/// <summary>
		/// 入力値チェック
		/// </summary>
		/// <param name="batsVal">打数</param>
		/// <param name="hitsVal">安打数</param>
		/// <returns>エラー有り：エラーメッセージ, エラー無し：空白</returns>
		private string InputCheck(string batsVal, string hitsVal)
		{

			//  1 - 1.未入力チェック
			//「打数」または「安打数」が空白の場合
			//              メッセージ：「打数、安打数を両方入力してください」													
			//   をダイアログに表示して処理終了
			if (string.IsNullOrWhiteSpace(batsVal) || string.IsNullOrWhiteSpace(hitsVal))
			{
				return "打数・安打数を両方入力してください";
			}

			//  1 - 2.正の整数チェック
			//「打数」または「安打数」の入力内容が正の整数以外の場合
			//  ※マイナス、小数点付きの数値をエラーにする
			//              メッセージ：「打数、安打数は正の整数で入力してください」													
			//   をダイアログに表示して処理終了


			if (!CheckPositiveNum(batsVal) || !CheckPositiveNum(hitsVal))
			{
				return "打数・安打数は正の整数で入力してください";
			}

			//  1 - 4.整合性チェック
			//「打数」＜「安打数」の場合
			//              メッセージ：「安打数は打数以下の値を入力してください」

			// ※ 1 - 2.正の整数チェックが終わっているのでint.Parseがエラーになる心配がない

			if (int.Parse(batsVal) < int.Parse(hitsVal))
			{
				return "安打数は打数以下の値を入力してください";

			}

			// ここまでのチェック結果がOKなのでエラー無し(空白)を返却
			return "";
		}


		/// <summary>
		/// 正の整数チェック
		/// </summary>
		/// <param name="checkVal">チェック対象の値</param>
		/// <returns>チェック対象が正の整数の場合：true</returns>
		private bool CheckPositiveNum(string checkVal)
		{
			int checkIntVal;
			if (int.TryParse(checkVal, out checkIntVal))
			{
				// 数値変換成功
				if (checkIntVal < 0)
				{
					// 負の整数なのでfalseを返却
					return false;
				}
			}
			else
			{
				// 整数ではないのでfalseを返却
				return false;
			}

			// 正の整数であることが確認できたのでtrueを返却
			return true;
		}

		/// <summary>
		/// 打率計算メソッド
		/// </summary>
		/// <param name="batsVal">打数</param>
		/// <param name="hitsVal">安打数</param>
		/// <returns>打率</returns>
		private double CalcAverage(double batsDoubleVal, double hitsDoubleVal)
		{
			//打率 ＝ 安打数÷打数

			// 計算を実施(少数第三位で四捨五入)
			double retVal = Math.Round(hitsDoubleVal / batsDoubleVal, 3, MidpointRounding.AwayFromZero);

			// 計算結果を返却
			return retVal;
		}


		/// <summary>
		/// 打率を表示用文字列にフォーマットする
		/// </summary>
		/// <param name="averageVal">打率の値(double)</param>
		/// <returns>打率表示文字列(x 割 y 分 z 厘)</returns>
		private string FormatAverage(double averageVal)
		{
			// 打率表示書式
			string format = "{0} 割 {1} 分 {2} 厘";

			// 打率表示文字列
			string retVal = "";

			if (averageVal == 0.0)
			{
				// 0割は個別に処理
				retVal = string.Format(format, 0, 0, 0);
			}
			else if (averageVal == 1.0)
			{
				// 10割は個別に処理
				retVal = string.Format(format, 10, 0, 0);
			}
			else
			{
				// 小数点以下が5ケタになるように右ゼロ埋め
				string padVal = averageVal.ToString().PadRight(7, '0');
				//Console.WriteLine("padVal:" + padVal);

				// 少数点以下の値を配列に入れる
				// 配列の一桁目：割, 二桁目：分, 三桁目：厘
				char[] averageArray = padVal.ToCharArray(2, 5);
				//Console.WriteLine("averageArray:" + averageArray);
				retVal = string.Format(format, averageArray[0], averageArray[1], averageArray[2]);
			}

			return retVal;
		}

		/// <summary>
		/// テキストボックスを全選択状態にする
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectAll(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			txt.SelectAll();
		}


		#endregion
	}
}

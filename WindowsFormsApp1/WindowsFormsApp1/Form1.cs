using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static void Main()
        {
            Application.Run(new Form1());
        }



        /// <summary>
        /// メインフォーム初期表示
        /// </summary>
        private void Clear()
        {
            batsText.Text = "0";
            hitsText.Text = "0";
            averageText.Text = "";
        }


        public void inputCheck()
        {
            if (batsText.Text == "2")
            {
                MessageBox.Show("打数・安打数を正の整数で入力してください");
                Clear();
            }
        }

        


        /// <summary>
        /// 計算ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculationButtons_click(object sender, EventArgs e)
        {

            // 1.入力チェックを行う
            
            // 入力チェック結果を取得
            string message = InputCheck(batsText.Text, hitsText.Text);


            // ⇒入力チェックの結果、エラーがあればメッセージをダイアログに出して処理終了

            // ⇒入力チェックの結果、エラーが無ければ2へ




            // 2.打率計算を行う
            double averageVal = CalcAverage(batsText.Text, hitsText.Text);



            // 3.計算結果を表示
            averageText.Text = FormatAverage(averageVal);




         




        }

        private string FormatAverage(double averageVal)
        {
            // TODO:スタブなので単にstringにして返しておく
            return (0.324).ToString();
        }


        /// <summary>
        /// 打率計算メソッド
        /// </summary>
        /// <param name="batsVal">打数</param>
        /// <param name="hitsVal">安打数</param>
        /// <returns>打率</returns>
        private double CalcAverage(string batsVal, string hitsVal)
        {
            // TODO:スタブなので固定値を返すことにしておく
            return 0.323;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="batsVal"></param>
        /// <param name="hitsVal"></param>
        /// <returns></returns>
        private string InputCheck(string batsVal, string hitsVal)
        {

            //  1 - 1.未入力チェック
            //「打数」または「安打数」が空白の場合
            //              メッセージ：「打数、安打数を両方入力してください」													
            //   をダイアログに表示して処理終了
            if (batsVal == "" || hitsVal == "")
            {
                MessageBox.Show("打数・安打数を両方入力してください");
                Clear();
            }



            //  1 - 2.正の整数チェック
            //「打数」または「安打数」の入力内容が正の整数以外の場合
            //  ※マイナス、小数点付きの数値をエラーにする
            //              メッセージ：「打数、安打数は正の整数で入力してください」													
            //   をダイアログに表示して処理終了

            int i = int.Parse(batsVal);
            int bl = int.Parse(hitsVal);
            double d = double.Parse(batsVal);

            if (i < 0 )
            {
                MessageBox.Show("打数・安打数は正の整数で入力してください");
            }

            

            //  1 - 4.整合性チェック
            //「打数」＜「安打数」の場合
            //              メッセージ：「安打数は打数以下の値を入力してください」													




            // TODO:スタブなので空白を返すことにしておく
            return "";
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
        /// 終了ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// インプットチェック　スタブ
        /// </summary>
        /// <param name="checkVal"></param>
        /// <returns></returns>
        private bool numCheck(string checkVal)
        {
            // TODO:スタブ
            return true;

            
        }


    }
}

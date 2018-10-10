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
            // メインフォーム初期表示
            Clear();
        }

        static void Main()
        {
            Application.Run(new Form1());          
        }
        
        // /クリアメソッド
        private void Clear()
        {
            batsText.Text = "0";
            hitsText.Text = "0";
            averageText.Text = "";
        }

 

        // 計算ボタンクリックイベント
        private void calculationButtons_click(object sender, EventArgs e)
        {
            // 入力チェック結果を取得
            string message = InputCheck(batsText.Text, hitsText.Text);

            // ⇒入力チェックの結果、エラーがあればメッセージをダイアログに出して処理終了
            if (!(message == null)) {
                MessageBox.Show(message);
                return;
            }

            // 打数がゼロの場合、"-" を表示
            if (batsText.Text == "0")
            {
                averageText.Text = "-";
            }
            // 打数がゼロ以外の場合
            // 打率計算を実施       
            else 
            {
             double batsVal = double.Parse(batsText.Text);
             double hitsVal = double.Parse(hitsText.Text);

             double averageVal = CalcAverage(batsVal, hitsVal);

             // 打率表示整形メソッドの結果をstring型に代入
             string aveCharacterString = AveFormat(averageVal);
             // 打率表示テキストボックスのテキストに代入
             averageText.Text = aveCharacterString;
            }             
        }
            

        // 打率表示整形メソッド
        private string AveFormat(double averageVal)
        {             
             // 打率数値をdouble型に代入
             double ave = averageVal;
             // ave == 1 の時、「10 割 0 分 0 厘」と表示
             if (ave == 1)
             {
                 return "10 割 0 分 0 厘";
             }
             // ave == 0 の時、「0 割 0 分 0 厘」と表示
             else if (ave == 0)
             {
                 return "0 割 0 分 0 厘";
             }

             // 打率数値をゼロ埋めし、string型に代入
             string aveText = string.Format("{0:f3}\r\n", ave);
               
             // 打率数値をテキストにし、文字列の配置で数値を取り出す
             char ave1 = aveText[2];
             char ave2 = aveText[3];
             char ave3 = aveText[4];
             //「x 割 y 分 z 厘」に表示整形し、打率表示整形メソッドに返す
             return ave1 + " " + "割" + " " + ave2 + " " + "分"+ " "  + ave3 + " " + "厘";
         }


        /// <summary>
        /// 打率計算メソッド
        /// </summary>
        /// <param name="batNum">打数</param>
        /// <param name="hitNum">安打数</param>
        /// <returns></returns>
        private double CalcAverage(double batNum, double hitNum)
        {
            // 打率を計算
            double aveRounding = hitNum / batNum;
            // 打率を小数点第四位で四捨五入し、打率計算メソッドに返す
            return Math.Round(aveRounding, 3, MidpointRounding.AwayFromZero);
        }
            

        /// <summary>
        /// 入力チェックメソッド
        /// </summary>
        /// <param name="batsVal">打数値</param>
        /// <param name="hitsVal">安打数値</param>
        /// <returns></returns>
        private string InputCheck(string batsVal, string hitsVal)
        {
            // 未入力チェック
            //「打数」が空白の場合
            if (!string.IsNullOrWhiteSpace(batsText.Text))
            {
             //nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
             else 
            {
                // null、もしくは空文字列、もしくは空白文字列である
                // メッセージ：「打数、安打数を両方入力してください」をダイアログに表示して処理終了
                return "打数、安打数を両方入力してください";
            }

            //「安打数」が空白の場合
            if (!string.IsNullOrWhiteSpace(hitsText.Text))
            {
                // nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
            else
            {
                // null、もしくは空文字列、もしくは空白文字列である
                // メッセージ：「打数、安打数を両方入力してください」をダイアログに表示して処理終了
                return "打数、安打数を両方入力してください";
            }


            // 正の整数チェック
            //「打数」の入力内容が正の整数以外の場合
            // ※文字、小数点付きの数値をエラーにする
            // メッセージ：「打数、安打数は正の整数で入力してください」をダイアログに表示して処理終了
            int number1 = 0;
            bool canConvert = int.TryParse(batsVal , out number1);
            if (canConvert == true)
            {

            }
            else
            {
                return "打数、安打数は正の整数で入力してください";
            }

            // 「安打数」の入力内容が正の整数以外の場合
            // ※文字、小数点付きの数値をエラーにする
            // メッセージ：「打数、安打数は正の整数で入力してください」をダイアログに表示して処理終了
            int number2 = 0;
            
            canConvert = int.TryParse(hitsVal, out number2);
            if (canConvert == true)
            {

            }
            else
            {
                return "打数、安打数は正の整数で入力してください";
            }
                

            // ※マイナス数値をエラーにする
            // メッセージ：「打数、安打数は正の整数で入力してください」をダイアログに表示して処理終了
            double batNum = double.Parse(batsVal);
            double hitNum = double.Parse(hitsVal);

            if (batNum < 0 || hitNum < 0)
            {
                return "打数、安打数は正の整数で入力してください";

            }


            // 整合性チェック
            //「打数」＜「安打数」の場合
            // メッセージ：「安打数は打数以下の値を入力してください」

            if (batNum < hitNum)
            {
                return "安打数は打数以下の値を入力してください";
            }       
            
            return null;
        }


        // クリアボタンクリックイベント
        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
       
        // 終了ボタンクリックイベント
        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

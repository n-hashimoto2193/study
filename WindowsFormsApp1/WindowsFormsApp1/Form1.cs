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
            Clear();
        }


        static void Main()
        {
            Application.Run(new Form1());          
        }

        

        /// <summary>
        /// メインフォーム初期表示/クリア機能
        /// </summary>
        private void Clear()
        {
            batsText.Text = "0";
            hitsText.Text = "0";
            averageText.Text = "";
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
            if (!(message == null)) {
                MessageBox.Show(message);
                return;
            }

            
                // 2.打率計算を行う  

                // 1 - 5 打数がゼロの場合
                if (batsText.Text == "0")
            {
                averageText.Text = "-";
            }

            //打数がゼロ以外の場合
            //打率計算を実施

            
            
            else 
            {
             double batsVal = double.Parse(batsText.Text);
             double hitsVal = double.Parse(hitsText.Text);

             double averageVal = CalcAverage(batsVal, hitsVal);
             // 3.計算結果を表示

             averageText.Text = (averageVal).ToString();
             string aveCharacterString = AveFormat(averageVal);

                averageText.Text = aveCharacterString;



            }
         
                

        }
        // 3.計算した打率を打率表示テキストボックスに表示
        //打率計算メソッドの結果を小数値を　「x割y分z厘」　のフォーマットに整形する

        //打率表示整形メソッド

            private string AveFormat(double averageVal)
            {
                
                double ave = averageVal;
                if (ave == 1)
                {
                    return "10 割 0 分 0 厘";
                }
                else if (ave == 0)
                {
                    return "0 割 0 分 0 厘";
                }
                string aveText = ave.ToString();
                

                char ave1 = aveText[2];
                char ave2 = aveText[3];
                char ave3 = aveText[4];
            //string ave1 = aveText.Substring(2,1);
            //string ave2 = aveText.Substring(3,1);
            //string ave3 = aveText.Substring(4,1);

            return ave1 + " " + "割" + " " + ave2 + " " + "分"+ " "  + ave3 + " " + "厘";
            }


        //string stTarget = "ABCDEFG";

        // 4 の要素にあたる文字を取得する
        //char chOne = stTarget[4];






        //実行確認でコメントアウト
        //private string FormatAverage(double averageVal)
        //{
        // TODO:スタブなので単にstringにして返しておく
        // return (0.324).ToString();
        //}


        /// <summary>
        /// 打率計算メソッド
        /// </summary>
        /// <param name="batsVal">打数</param>
        /// <param name="hitsVal">安打数</param>
        /// <returns>打率</returns>




        private double CalcAverage(double batNum, double hitNum)
        {
            //Console.WriteLine("★batsVal：" + batsVal);
            //Console.WriteLine("★hitsVal：" + hitsVal);


            double aveRounding = hitNum / batNum;
            return Math.Round(aveRounding, 3, MidpointRounding.AwayFromZero);


            // TODO:スタブなので固定値を返すことにしておく
            //double retVal = hitNum / batNum;

            //Console.WriteLine("★retVal：" + retVal);

            //return retVal;

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
            if (!string.IsNullOrWhiteSpace(batsText.Text))
            {
             //nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
             else 
            {
             //null、もしくは空文字列、もしくは空白文字列である
             return "打数、安打数を両方入力してください";
            }

            if (!string.IsNullOrWhiteSpace(hitsText.Text))
            {
                //nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
            else
            {
                //null、もしくは空文字列、もしくは空白文字列である
                return "打数、安打数を両方入力してください";
            }

      

            double batNum = double.Parse(batsVal);
            double hitNum = double.Parse(hitsVal);


            








            //  1 - 2.正の整数チェック
            //「打数」または「安打数」の入力内容が正の整数以外の場合
            //  ※マイナス、小数点付きの数値をエラーにする
            //              メッセージ：「打数、安打数は正の整数で入力してください」													
            //   をダイアログに表示して処理終了

            if (batNum < 0  || hitNum < 0)
            {
                return "打数、安打数は正の整数で入力してください";

            }



            //  1 - 3.整合性チェック
            //「打数」＜「安打数」の場合
            //              メッセージ：「安打数は打数以下の値を入力してください」
            
            if (batNum < hitNum)
            {
                return "安打数は打数以下の値を入力してください";
            }       
            


            // TODO:スタブなので空白を返すことにしておく
            return null;
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
            return false;

            
        }


    }
}

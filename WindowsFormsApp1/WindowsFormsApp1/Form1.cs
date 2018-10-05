﻿using System;
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
             double averageVal = CalcAverage(batsText.Text, hitsText.Text);
             // 3.計算結果を表示
             //実行確認でコメントアウト
             //averageText.Text = FormatAverage(averageVal);

                averageText.Text = (averageVal).ToString();
            }


        

        }
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
        private double CalcAverage(string batsVal, string hitsVal)
        {
            //Console.WriteLine("★batsVal：" + batsVal);
            //Console.WriteLine("★hitsVal：" + hitsVal);

            double batNum = double.Parse(batsVal);
            double hitNum = double.Parse(hitsVal);

            


            return hitNum / batNum;


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
                // nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
            else if (!string.IsNullOrWhiteSpace(hitsText.Text))
            {
                // nullではなく、かつ空文字列でもなく、かつ空白文字列でもない
            }
            else 
            {
                // null、もしくは空文字列、もしくは空白文字列である
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

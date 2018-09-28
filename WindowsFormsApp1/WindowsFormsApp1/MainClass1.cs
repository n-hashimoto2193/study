using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MainClass1
    {
        public MainClass1()
        {
            //
            //　TODO: コンストラクタ　ロジックをここに追加
            //
        }
        public static void Main()
        {
            //メッセージダイアログボックスを表示
            System.Windows.Forms.MessageBox.Show("開始します。", "通知");

            //フォームを表示
            System.Windows.Forms.Application.Run(new Form1());
        }
    }
}

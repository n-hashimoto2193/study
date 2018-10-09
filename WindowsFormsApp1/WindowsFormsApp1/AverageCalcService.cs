using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    /// <summary>
    /// 打率計算アプリサービスクラス
    /// </summary>
    class AverageCalcService
    {
        /// <summary>
        /// 正の整数チェック
        /// </summary>
        /// <param name="checkVal">チェック対象の値</param>
        /// <returns>チェック対象が正の整数の場合：true</returns>
        public bool CheckPositiveNum(string checkVal)
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
    }
}

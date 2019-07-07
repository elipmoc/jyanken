using System;
using System.Collections.Generic;

namespace Application
{
    // ユーザーとのやりとりをするインターフェイス
    interface IView
    {
        event Action<string> OnInput;

        // 入力を促す
        void ShowRequest();
        
        // 再入力を促す
        void ShowTryRequest();

        // 勝敗を出力する
        void ShowResult(string result, string myHand, IEnumerable<string> aiHands);
    }
}
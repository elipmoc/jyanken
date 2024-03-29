﻿using System;
using System.Collections.Generic;

namespace UserInterface
{
    // コンソールの入出力をするクラス
    class ConsoleView : Application.IView
    {
        public event Action<string> OnInput;

        // 入力を促す
        public void ShowRequest()
        {
            Console.WriteLine("ジャンケンの手を選んでください（1=グー,2=チョキ,3=パー）");
            var input = Console.ReadLine();
            OnInput(input);
        }
        
        // 再入力を促す
        public void ShowTryRequest()
        {
            Console.WriteLine("もう一度入力してください");
            ShowRequest();
        }

        // 勝敗を出力する
        public void ShowResult(string result, string myHand, IEnumerable<string> aiHands)
        {
            Console.WriteLine("あなた:" + myHand);
            foreach (var aiHand in aiHands)
                Console.WriteLine("AI:" + aiHand);
            Console.WriteLine("あなたは" + result + "です");
        }
    }
}
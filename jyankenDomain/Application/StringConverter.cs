﻿using Domain;

namespace Application
{
    // 文字列と相互変換する
    static class StringConverter
    {
        // 文字列をHandKindへ変換
        static public HandKind? StringToHandKind(string consoleString)
        {
            int result;
            if (int.TryParse(consoleString, out result) == false) return null;
            if (result < 1 || result > 3) return null;
            var handKinds = new HandKind[] { HandKind.Guu, HandKind.Tyoki, HandKind.Paa };
            return handKinds[result - 1];
        }

        // ResultKindを文字列へ変換
        static public string ResultKindToString(ResultKind resultKind)
        {
            switch (resultKind)
            {
                case ResultKind.Draw:
                    return "引き分け";
                case ResultKind.Win:
                    return "勝利";
                default:
                    return "敗北";
            }
        }

        // ResultKindを文字列へ変換
        static public string HandKindToString(HandKind handKind)
        {
            switch (handKind)
            {
                case HandKind.Guu:
                    return "グー";
                case HandKind.Tyoki:
                    return "チョキ";
                default:
                    return "パー";
            }
        }
    }
}
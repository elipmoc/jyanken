﻿using System.Collections.Generic;

namespace Domain
{
    // ジャンケンのルールを表すインターフェイス
    interface IRule
    {
        // 勝敗を判定する
        ResultKind Judge(HandKind myHand, IEnumerable<HandKind> otherHands);
    }
}

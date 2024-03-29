﻿using System.Collections.Generic;

// Enum名の省略
using static Domain.HandKind; 
using static Domain.ResultKind;

namespace Domain
{
    // もっとも一般的なジャンケンのルール
    class StandardRule : IRule
    {
        // 勝敗を判定する
        public ResultKind Judge(HandKind myHand, IEnumerable<HandKind> otherHands)
        {
            uint winCount = 0;
            uint loseCount = 0;
            foreach (var otherHand in otherHands)
            {
                var resultKind = Judge(myHand, otherHand);
                if (resultKind == Win) winCount++;
                else if (resultKind == Lose) loseCount++;
            }
            if (winCount * loseCount != 0 || winCount + loseCount == 0) return Draw;
            if (winCount != 0) return Win;
            return Lose;
        }

        // 1対1の時の勝敗判定
        private ResultKind Judge(HandKind myHand, HandKind otherHand)
        {
            if (myHand == otherHand) return Draw;
            if (
                (myHand == Guu && otherHand == Paa) ||
                (myHand == Tyoki && otherHand == Guu) ||
                (myHand == Paa && otherHand == Tyoki)
                )
                return Lose;
            return Win;
        }
    }
}
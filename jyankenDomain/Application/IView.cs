using System;
using System.Collections.Generic;

namespace Application
{
    interface IView
    {
        event Action<string> OnInput;

        void ShowTryRequest();

        void ShowRequest();

        void ShowResult(string result, string myHand, IEnumerable<string> aiHands);
    }
}
using System;
using System.Linq;
using Domain;

namespace Application
{
    class Game
    {
        public Game(IView view, Random rand)
        {
            view.OnInput += input =>
            {
                var handKind = StringConverter.StringToHandKind(input);
                if (handKind == null)
                {
                    view.ShowTryRequest();
                    return;
                }
                var player = new Human<StandardRule>(new StandardRule(), (HandKind)handKind);
                var aiHumen = new AiHumanCreator(rand).CreateAiHumen(new StandardRule(), 2);
                view.ShowResult(
                    StringConverter.ResultKindToString(
                        player.KnowResult(aiHumen)
                    ),
                    StringConverter.HandKindToString(player.Hand),
                    aiHumen.Select(x => StringConverter.HandKindToString(x.Hand))
                );
            };
            view.ShowRequest();
        }
    }
}
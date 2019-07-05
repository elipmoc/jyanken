using System;
using Domain;

namespace Application
{
    // Aiの人間を生成するクラス
    class AiHumanCreator
    {
        private readonly Random rand;

        public AiHumanCreator(Random rand) => this.rand = rand;
        public Human<Rule>[] CreateAiHumen<Rule>(Rule rule, uint size) where Rule : IRule
        {
            var handKinds = new HandKind[] { HandKind.Guu, HandKind.Tyoki, HandKind.Paa };
            var aiHumen = new Human<Rule>[size];
            for (int i = 0; i < aiHumen.Length; i++)
            {
                var aiHandKind = handKinds[rand.Next(3)];
                aiHumen[i] = new Human<Rule>(rule, aiHandKind);

            }
            return aiHumen;
        }
    }
}

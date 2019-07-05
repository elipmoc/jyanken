using System.Linq;

namespace Domain
{
    // ジャンケンをする人間を表す
    class Human<Rule> where Rule : IRule
    {
        private readonly Rule rule;
        public HandKind Hand { get; }

        // ルールと出す手をセット
        public Human(Rule rule, HandKind hand)
        {
            this.rule = rule;
            this.Hand = hand;
        }

        // 勝敗を知る
        public ResultKind KnowResult(Human<Rule>[] otherHumen)
            => rule.Judge(Hand, otherHumen.Select(x => x.Hand));
    }
}
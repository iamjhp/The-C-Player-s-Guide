using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCard {
    public class Card {
        public Color Color { get; }
        public Rank Rank { get; }

        public Card(Color color, Rank rank) {
            Color = color;
            Rank = rank;
        }

        public bool isSymbol => Rank == Rank.DollarSign || Rank == Rank.Percent || Rank == Rank.Caret || Rank == Rank.Ampersand;
        public bool isNumber => !isSymbol;
    }
}

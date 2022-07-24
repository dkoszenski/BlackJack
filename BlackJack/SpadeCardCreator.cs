using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpadeCardCreator : ICardCreator {
    public Card CreateCard(int i) {
        return new Card(Suite.Spade, (CardValue)i);
    }
}

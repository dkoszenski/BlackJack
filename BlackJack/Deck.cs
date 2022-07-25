using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Deck {
    private ICardCreator[] _creators = new ICardCreator[] { new HeartCardCreator(), new DiamondCardCreator(), new SpadeCardCreator(), new ClubCardCreator() };
    public List<Card> deck = new List<Card>();
    public void CreateDeck() {
        foreach(ICardCreator creator in _creators) {
            foreach( int value in Enum.GetValues(typeof(CardValue))) {
                deck.Add(creator.CreateCard(value));
            }
        }
    }

    public void PrintDeck() {
        foreach(Card card in deck) {
            card.PrintCard();
        }
    }
}
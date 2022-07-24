using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void Main(string[] arrgs) {
        Deck newDeck = new Deck();
        newDeck.createDeck();
        newDeck.PrintDeck();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Card {
    public Suite Suite { get; set; }
    public CardValue Value { get; set; }
    public Card(Suite suite, CardValue value) {
        this.Suite = suite;
        this.Value = value;
    }

    public void PrintCard() {
        Console.WriteLine((int)this.Value);
    }
}

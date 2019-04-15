using System;

public class Card
{
    String face;
    String suit;

    public Card()
    {
    }

    public Card(String card, String type)
    {
        face = card;
        suit = type;
    }

    public override string ToString()
    {
        return face + " of " + suit;
    }

    public int GetValue()
    {
        int tmp = -1;
        if (Int32.TryParse(face, out tmp))
        {
            return tmp;
        }
        else if (face == "Ace")
        {
            return 11;
        }
        else
        {
            return 10;
        }
    }

    public String FileName()
    {
        if (face == "10")
        {
            return Char.ToUpper(suit[0]) + "10" + ".gif";
        }
        else
        {
            return Char.ToUpper(suit[0]) +""+ Char.ToUpper(face[0]) + "" + ".gif";
        }

    }
}

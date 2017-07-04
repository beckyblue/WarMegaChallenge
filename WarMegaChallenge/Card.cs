using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarMegaChallenge
{
    public class Card
    {
        public string Suit { get; set; }    
        public string Type { get; set; }    

        public int CardValue()
        {
            int value = 0;

            // iterates through each card value to find the "win"
            switch (this.Type)
            {
                case "Ace":
                    value = 14;
                    break;

                case "King":
                    value = 13;
                    break;

                case "Queen":
                    value = 12;
                    break;

                case "Jack":
                    value = 11;
                    break;

                default:
                    value = int.Parse(this.Type);
                    break;     
                
            }
            return value;
        }
    }
}
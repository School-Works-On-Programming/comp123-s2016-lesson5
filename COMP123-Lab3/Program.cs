using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author : Christopher Ritchil
 * Student Number : 300702644
 * Description : This program demostrate dealing with card decks
 * Date created: Jun 07, 2016
 * Date modified: Jun 10, 2016
 * Version: 0.1.0
 */
namespace COMP123_Lab3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {

        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // List that represents deck of card

            Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // display the initial state of the deck

            deck.Shuffle(); // shuffle the deck
            deck.Display(); // display shuffled deck
            Console.WriteLine("=====================");

            Card cardDealt = deck.Deal();
            Console.WriteLine("Card dealt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author : Christopher Ritchil
 * Student Number : 300702644
 * Description : This is a card class
 * Date created: Jun 07, 2016
 * Date modified: Jun 10, 2016
 * Version: 0.1.0
 */
namespace COMP123_Lab3
{
    public class Card
    {
        /**
         * <summary>
         * This class creates an object that represents a playing card
         * </summary>
         * 
         * @class Card
         */
        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }
        public string Suit { get; set; }
        /**
         * <summary>
         * This constructor takes two parameters: face and suit to instantiate a Card object
         * </summary>
         * 
         * @constructor Card
         * @param {string} face
         * @param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}

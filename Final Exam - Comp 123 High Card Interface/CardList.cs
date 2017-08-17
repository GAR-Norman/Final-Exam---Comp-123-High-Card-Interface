using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel Norman 
 * Student #: 300897331
 * Date: August 17, 2017 
 * Description: This is the cardList class
 * Version: 0.1 - Initial Commit
*/

namespace Final_Exam___Comp_123_High_Card_Interface
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test_1_301087895
{/*
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public List<int> ElementList
        {
            get

            {
                return _elementList;

            }

        }
        public int ElementNumber
        {
            get
            {
                return _elementNumber;
            }
            set
            {
                _elementNumber = value;
            }
        }
        public List<int> NumberList
        {
            get
            {
                return _numberList;
            }

        }
        public Random random
        {
            get
            {
                return _random;
            }

        }
        public int SetSize
        {
            get
            {
                return _setSize;
            }
            set
            {
                _setSize = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _initialize()
        {
            _numberList=new List<int>();
            _elementList = new List<int>();
            _random = new Random();
        }

        private void _build()
        { 
            int i=0;
            while (i < SetSize)
            {
                NumberList.Add(i++);
            }
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void PickElements()
        {
            if (ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();
                _build();

            }

            int i = 0;
            while (i<ElementNumber)
            {
                int randNumber = _random.Next(NumberList.Count);
                NumberList.Remove(randNumber);
                ElementList.Add(randNumber);
                i++;
            }

            ElementList.Sort();
        }
    }
}
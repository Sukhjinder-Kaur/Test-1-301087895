using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Name=Sukhjinder Kaur
Student number= 301087895
Date last Modified = 15 / 07 / 2020
Program description= This is the derived class of LottoGames*/

namespace Test_1_301087895
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }
        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            int t = 1;
            while (t <= 7)
            {
                PickElements();
                Console.Write($"Ticket {t}: ");
                Console.WriteLine(ToString());
                t++;
            }
        }
    }
}
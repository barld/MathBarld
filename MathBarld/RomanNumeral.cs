using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public class RomanNumeral
    {
        #region private fields
        /// <remarks>
        /// start with an emtpty string because there is no 0
        /// </remarks>
        private string _romanNumber = "";
        private int _decimalNumber = 0;
        private readonly char[] marks = new char[] { 'i', 'v', 'x', 'l', 'c', 'd', 'm' };
        #endregion

        #region constructors
        public RomanNumeral(int decimalNumber)
        {
            if (decimalNumber < 1) throw new ArgumentOutOfRangeException("decimalNumber", decimalNumber, "roman numbers has no zero and negative numbers suport");



            this._decimalNumber = decimalNumber;
        }

        public RomanNumeral(string romanNumber)
        {
            //check of alle karakters geldig zijn voor een romeins cijfer
            if (!romanNumber.ToList().TrueForAll(c => marks.ToList().Exists(num => num == c))) throw new ArgumentException("roman number bevat tekens die niet worden ondersteunt");
            
        }
        #endregion

        #region public properties
        public int Decimal { get { return this._decimalNumber; } }
        #endregion

        #region operator overloading
        public static RomanNumeral operator +(RomanNumeral a, RomanNumeral b)
        {
            return new RomanNumeral(a._decimalNumber + b._decimalNumber);
        }

        public static RomanNumeral operator -(RomanNumeral a, RomanNumeral b)
        {
            return new RomanNumeral(a._decimalNumber - b._decimalNumber);
        }

        public static RomanNumeral operator *(RomanNumeral a, RomanNumeral b)
        {
            return new RomanNumeral(a._decimalNumber * b._decimalNumber);
        }

        public static RomanNumeral operator /(RomanNumeral a, RomanNumeral b)
        {
            return new RomanNumeral(a._decimalNumber / b._decimalNumber);
        }
        #endregion

        #region overide object methods
        public override string ToString()
        {
            return this._romanNumber;
        }

        #endregion
    }
}

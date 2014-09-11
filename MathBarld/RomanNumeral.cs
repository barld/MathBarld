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
        string _romanNumber = "";
        int _decimalNumber = 0;
        #endregion

        #region public properties
        public int Decimal { get { return this._decimalNumber; } }
        #endregion

        #region operator overloading
        public static RomanNumeral operator +(RomanNumeral a, RomanNumeral b)
        {
            throw new NotImplementedException();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    /// <summary>
    /// Een object wat een cijfer op zich is en uit gaat van het decimale stelsel
    /// </summary>
    public class Breuk
    {
        #region public properties
        public int Teller { get; set; }
        public int Noemer { get; set; }
        #endregion

        #region constructors
        public Breuk(int teller, int noemer)
        {
            this.Teller = teller;
            this.Noemer = noemer;
        }
        #endregion

        #region overwrites
        public override string ToString()
        {
            return string.Format("{0}/{1}", this.Teller, this.Noemer);
        }

        #endregion

        #region operator oveloads
        /// <summary>
        /// let op getal wordt standaard niet genormaliseerd
        /// </summary>
        /// <param name="breakA"></param>
        /// <param name="breukB"></param>
        /// <returns></returns>
        public static Breuk operator +(Breuk breakA, Breuk breukB)
        {
            int teller = breakA.Teller * breukB.Noemer + breukB.Teller * breakA.Noemer;
            int noemer = breakA.Noemer * breukB.Noemer;

            return new Breuk(teller, noemer);
        }

        public static Breuk operator -(Breuk breakA, Breuk breukB)
        {
            int teller = breakA.Teller * breukB.Noemer - breukB.Teller * breakA.Noemer;
            int noemer = breakA.Noemer * breukB.Noemer;

            return new Breuk(teller, noemer);
        }

        public static Breuk operator *(Breuk breakA, Breuk breukB)
        {
            int teller = breakA.Teller * breukB.Teller;
            int noemer = breakA.Noemer * breukB.Noemer;

            return new Breuk(teller, noemer);
        }

        /// <summary>
        /// op basi van turn keep flip
        /// </summary>
        /// <param name="breakA"></param>
        /// <param name="breukB"></param>
        /// <returns></returns>
        public static Breuk operator /(Breuk breakA, Breuk breukB)
        {
            int teller = breakA.Teller * breukB.Noemer;
            int noemer = breakA.Noemer * breukB.Teller;

            return new Breuk(teller, noemer);
        }

        public static bool operator ==(Breuk breakA, Breuk breukB)
        {
            return breakA.Teller == breukB.Teller && breakA.Noemer == breukB.Noemer;
        }

        public static bool operator !=(Breuk breakA, Breuk breukB)
        {
            return !(breakA == breukB);
        }

        public override bool Equals(object obj)
        {
            Breuk b = obj as Breuk;
            return this.Noemer == b.Noemer && this.Teller == b.Teller;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}

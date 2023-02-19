using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumberExtend : RomanNumber
    {
        public RomanNumberExtend(ushort number) : base(number)
        {
        }
        public RomanNumberExtend(string number) : base(number)
        {
        }
        /*public static RomanNumberExtend operator +(RomanNumberExtend romanNumber1,RomanNumberExtend romanNumber2)
        {
            RomanNumberExtend romanNumber = new RomanNumberExtend(romanNumber1.ToUint16());
            romanNumber.Add(romanNumber1,romanNumber2);
            return  romanNumber;
        }*/
        public static RomanNumberExtend operator +(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2)
        {
            if (romanNumber1 == null || romanNumber2 == null || romanNumber1.ToUint16() + romanNumber2.ToUint16() > 3999)
            {
                throw new RomanNumberException("#ERROR");
            }
            RomanNumberExtend romanNumber = new RomanNumberExtend(0);
            romanNumber.Add(romanNumber1, romanNumber2);
            return romanNumber;
        }
        public static RomanNumberExtend operator -(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2)
        {
            if (romanNumber1 == null || romanNumber2 == null || romanNumber1.ToUint16() - romanNumber2.ToUint16() <= 0|| romanNumber1.ToUint16() - romanNumber2.ToUint16() > 3999)
            {
                throw new RomanNumberException("#ERROR");
            }
            RomanNumberExtend romanNumber = new RomanNumberExtend(0);
            romanNumber.Sub(romanNumber1, romanNumber2);
            return romanNumber;
        }
        public static RomanNumberExtend operator *(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2)
        {
            if (romanNumber1 == null || romanNumber2 == null || romanNumber1.ToUint16()*romanNumber2.ToUint16() > 3999)
            {
                throw new RomanNumberException("#ERROR");
            }
            RomanNumberExtend romanNumber = new RomanNumberExtend(0);
            romanNumber.Mul(romanNumber1, romanNumber2);
            return romanNumber;
        }
        public static RomanNumberExtend operator /(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2)
        {
            if (romanNumber1 == null || romanNumber2 == null || romanNumber1.ToUint16() / romanNumber2.ToUint16() < 1 || romanNumber1.ToUint16() / romanNumber2.ToUint16() > 3999)
            {
                throw new RomanNumberException("#ERROR");
            }
            RomanNumberExtend romanNumber = new RomanNumberExtend(0);
            romanNumber.Div(romanNumber1, romanNumber2);
            return romanNumber;

        }
    }
}

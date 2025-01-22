using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class RationalNumber
    {
        [DeveloperInfo("Даниил Дмитриев", "2025.01.01")]
        internal class RationalNumber
        {
            public int numerator;
            private int denominator;
            public int Denominator
            {
                get
                {
                    return denominator;
                }
                set
                {
                    if (denominator != 0)
                    {
                        denominator = value;
                    }
                }
            }
            public RationalNumber(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public override string ToString()
            {
                return $"{numerator}/{Denominator}";
            }
            public static bool operator ==(RationalNumber a, RationalNumber b)
            {
                return a.Equals(b);
            }
            public static bool operator !=(RationalNumber c, RationalNumber d)
            {
                return !(c == d);
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                RationalNumber other = (RationalNumber)obj;
                return numerator == other.numerator && Denominator == other.Denominator;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public static bool operator <(RationalNumber a, RationalNumber b)
            {
                return (a.numerator / a.Denominator < b.numerator / b.Denominator);
            }
            public static bool operator >(RationalNumber a, RationalNumber b)
            {
                return (a.numerator / a.Denominator > b.numerator / b.Denominator);
            }
            public static bool operator <=(RationalNumber a, RationalNumber b)
            {
                return (a.numerator / a.Denominator <= b.numerator / b.Denominator);
            }
            public static bool operator >=(RationalNumber a, RationalNumber b)
            {
                return (a.numerator / a.Denominator >= b.numerator / b.Denominator);
            }
            public static RationalNumber operator +(RationalNumber a, RationalNumber b)
            {
                int numerator = a.numerator * b.Denominator + b.numerator * a.Denominator;
                int Denominator = a.Denominator * b.Denominator;
                return new RationalNumber(numerator, Denominator);
            }
            public static RationalNumber operator -(RationalNumber a, RationalNumber b)
            {
                int numerator = a.numerator * b.Denominator - b.numerator * a.Denominator;
                int Denominator = a.Denominator * b.Denominator;
                return new RationalNumber(numerator, Denominator);
            }
            public static RationalNumber operator ++(RationalNumber a)
            {
                return new RationalNumber(a.numerator + a.Denominator, a.Denominator);
            }
            public static RationalNumber operator --(RationalNumber a)
            {
                return new RationalNumber(a.numerator - a.Denominator, a.Denominator);
            }
            public static RationalNumber operator %(RationalNumber a, RationalNumber b)
            {
                int numerator = (a.numerator * b.Denominator) % (b.numerator * a.Denominator);
                int Denominator = a.Denominator * b.Denominator;
                return new RationalNumber(numerator, Denominator);
            }
            public static RationalNumber operator *(RationalNumber a, RationalNumber b)
            {
                int numerator = a.numerator * b.numerator;
                int Denominanor = a.Denominator * b.Denominator;
                return new RationalNumber(numerator, Denominanor);
            }
            public static RationalNumber operator /(RationalNumber a, RationalNumber b)
            {
                int numerator = a.numerator * b.Denominator;
                int Denominanor = b.numerator * a.Denominator;
                return new RationalNumber(numerator, Denominanor);
            }
            public static explicit operator float(RationalNumber a)
            {
                return (float)a.numerator / a.Denominator;
            }

            public static explicit operator int(RationalNumber a)
            {
                return a.numerator / a.Denominator;
            }
        }
    }
}

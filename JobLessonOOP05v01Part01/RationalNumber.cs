using System;

namespace JobLessonOOP05v01Part01
{
    class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        { get { return _numerator; } set { _numerator = value; } }
        public int Denominator
        { get { return _denominator; } set { _denominator = value; } }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю!");
            }
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;
            CommonDivisor();
        }
        // Определение операторов ==, !=, <, >, <=, >=
        public static bool operator ==(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return !(rationalNumber1._numerator != rationalNumber2._numerator && rationalNumber1._denominator != rationalNumber2._denominator);
        }

        public static bool operator !=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return !(rationalNumber1._numerator == rationalNumber2._numerator && rationalNumber1._denominator == rationalNumber2._denominator);
        }
        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber < secondNumber);
        }
        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber > secondNumber);
        }
        public static bool operator <=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber <= secondNumber);
        }
        public static bool operator >=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            double firstNumber = (double)rationalNumber1._numerator / (double)rationalNumber1._denominator;
            double secondNumber = (double)rationalNumber2._numerator / (double)rationalNumber2._denominator;
            return (firstNumber >= secondNumber);
        }

        // Опредение операторов + - * / ++ --

        public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator + rationalNumber2._numerator * rationalNumber1._denominator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }

        public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator - rationalNumber2._numerator * rationalNumber1._denominator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }
        public static RationalNumber operator *(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._denominator;
            int newNumerator = rationalNumber1._numerator*rationalNumber2._numerator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }
        public static RationalNumber operator /(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int newDenominator = rationalNumber1._denominator * rationalNumber2._numerator;
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            return result;
        }
        public static RationalNumber operator ++(RationalNumber rationalNumber1)
        {
            int newNumerator = rationalNumber1._numerator + rationalNumber1._denominator;
            RationalNumber result = new RationalNumber(newNumerator, rationalNumber1._denominator);
            return result;
        }

        public static RationalNumber operator --(RationalNumber rationalNumber1)
        {
            int newNumerator = rationalNumber1._numerator - rationalNumber1._denominator;
            RationalNumber result = new RationalNumber(newNumerator, rationalNumber1._denominator);
            return result;
        }

        //Оператор целочисленного деления %
        public static RationalNumber operator %(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int newNumerator = rationalNumber1._numerator * rationalNumber2._denominator;
            int newDenominator = rationalNumber1._denominator * rationalNumber2._numerator;
            RationalNumber result = new RationalNumber(newNumerator, newDenominator);
            result._numerator /= (int)result._denominator;
            result._denominator = 1;
            return result;
        }

        // Операторы float и int
        public static explicit operator float(RationalNumber rationalNumber1)
        {
            return (float)rationalNumber1._numerator;
        }
        public static explicit operator int(RationalNumber rationalNumber1)
        {
            return (int)rationalNumber1._numerator;
        }
        private static int OperatorCommonDivisor(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            else
                return OperatorCommonDivisor(denominator, numerator % denominator);
        }

        // определение общего делителя для числителя и знаменателя.
        private void CommonDivisor()
        {
            int greatestCommonDivision = RationalNumber.OperatorCommonDivisor(_numerator, _denominator);
            _numerator /= greatestCommonDivision;
            _denominator /= greatestCommonDivision;

        }

        //переопределение ToSring для вывода дроби
        public override string ToString()
        {
            if (_numerator != 0)
            { string returnString = $"{_numerator}/{_denominator}"; return returnString; }
            else { return "0"; }
        }

        public override bool Equals(object obj)
        {
            return obj is RationalNumber number &&
                   _numerator == number._numerator &&
                   _denominator == number._denominator;
        }

        public override int GetHashCode()
        {
            int hashCode = 1796543463;
            hashCode = hashCode * -1521134295 + _numerator.GetHashCode();
            hashCode = hashCode * -1521134295 + _denominator.GetHashCode();
            return hashCode;
        }
    }
}

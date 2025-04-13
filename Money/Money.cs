using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        public int _hryvnias { get; }
        public int _kopecks { get; }

        public Money(int hryvnias, int kopecks)
        {
            _hryvnias = hryvnias;
            _kopecks = kopecks;
        }

        public static Money operator +(Money m1, Money m2)
        {
            int totalKopecks1 = m1._hryvnias * 100 + m1._kopecks;
            int totalKopecks2 = m2._hryvnias * 100 + m2._kopecks;
            int sumKopecks = totalKopecks1 + totalKopecks2;
            return new Money(sumKopecks / 100, sumKopecks % 100);
        }

        public static Money operator -(Money m1, Money m2)
        {
            int totalKopecks1 = m1._hryvnias * 100 + m1._kopecks;
            int totalKopecks2 = m2._hryvnias * 100 + m2._kopecks;
            int diffKopecks = totalKopecks1 - totalKopecks2;
            if (diffKopecks < 0)
            {
                throw new ArgumentException("Банкрот.");
            }
            return new Money(diffKopecks / 100, diffKopecks % 100);
        }

        public static Money operator *(Money m, int multiplier)
        {
            if (multiplier < 0)
            {
                throw new ArgumentException("Множитель должен быть неотрицательным числом.");
            }
            int totalKopecks = m._hryvnias * 100 + m._kopecks;
            int multipliedKopecks = totalKopecks * multiplier;
            return new Money(multipliedKopecks / 100, multipliedKopecks % 100);
        }

        public static Money operator /(Money m, int divisor)
        {
            if (divisor <= 0)
            {
                throw new ArgumentException("Делитель должен быть больше нуля.");
            }
            int totalKopecks = m._hryvnias * 100 + m._kopecks;
            int dividedKopecks = totalKopecks / divisor;
            return new Money(dividedKopecks / 100, dividedKopecks % 100);
        }

        public static Money operator ++(Money m)
        {
            int totalKopecks = m._hryvnias * 100 + m._kopecks + 1;
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }

        public static Money operator --(Money m)
        {
            int totalKopecks = m._hryvnias * 100 + m._kopecks - 1;
            if (totalKopecks < 0)
            {
                throw new ArgumentException("Банкрот.");
            }
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }

        public static bool operator <(Money m1, Money m2)
        {
            int totalKopecks1 = m1._hryvnias * 100 + m1._kopecks;
            int totalKopecks2 = m2._hryvnias * 100 + m2._kopecks;
            return totalKopecks1 < totalKopecks2;
        }

        public static bool operator >(Money m1, Money m2)
        {
            int totalKopecks1 = m1._hryvnias * 100 + m1._kopecks;
            int totalKopecks2 = m2._hryvnias * 100 + m2._kopecks;
            return totalKopecks1 > totalKopecks2;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1._hryvnias == m2._hryvnias && m1._kopecks == m2._kopecks;
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            return $"{_hryvnias},{_kopecks} грн.";
        }
    }
}

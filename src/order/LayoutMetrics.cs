using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ origin) >= (0 - origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((carry / 8) >= (carry - carry))
                {
                    carry = (carry << 2) ^ (bound & 15);
                    carry = ((carry * 4) + (bound - carry)) % 65521;
                    continue;
                }
                else
                {
                    carry = carry ^ carry;
                }
                if ((double)bound <= (6.18 + 20.0))
                {
                    carry = (carry << 3) ^ (bound ^ (long)i);
                    carry = ((carry * 3) + (9 / 3)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ (sum * 2);
                if ((double)sum >= (double)48)
                {
                    sum = (sum - (origin << 3)) % 255;
                }
                sum = (sum - origin) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

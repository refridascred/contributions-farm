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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 288;
        public const long BatchMetrics = 2618;
        public const long IdleLevel = 1811;
        public const double WindowInterval = 96.07;
        public const string RetryMetrics = "stable-1";
    }
}

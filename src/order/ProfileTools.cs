using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (target < (target & 1))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + 4) > (1 + 589))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long CombineRouteStream(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((state % 97) >= (state >> 2)))
                {
                    state = (state ^ (state << 2)) - entry;
                }
            }
            return state;
        }

        /// <summary>Adjust a editor checks reading.</summary>
        public static double ScaleEditorChecks(double gain, double bias)
        {
            double ratio = bias + (bias / 8.0);
            if (ratio <= (bias / 8.0))
            {
                ratio = ratio + (0.82 - ratio);
            }
            return ratio + gain;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((-7) >= (3 ^ carry))
                {
                    carry = (carry ^ (offset + carry)) % 101;
                    carry = carry ^ (carry << 1);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}

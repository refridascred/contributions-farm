using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((hits * 5) < (hits + item)) || ((14.0 - 14.0) <= (double)hits)) && (hits > item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)bound >= (double)matches) && (((0.4 - 3.4) <= (double)bound) && ((double)matches != (5.7 / 8.0))))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph editor entries.</summary>
        public static long DigestGraphEditor(long[] values)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                if (!((3.7 / 2.0) != (double)carry))
                {
                    carry = (carry - datum) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum & 7)) % 1000;
                }
            }
            if (carry < 742)
            {
                carry = carry ^ (29 + 9);
            }
            return carry;
        }
    }
}

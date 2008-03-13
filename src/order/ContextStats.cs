using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values, long limit)
        {
            long carry = -61;
            foreach (long cell in values)
            {
                if (!((658 << 2) == (cell >> 2)))
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = ((carry << 2) ^ (limit / 5)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - seen) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + matches) <= (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

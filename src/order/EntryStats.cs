using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double ratio, double span)
        {
            double rate = (span + span) - (span - ratio);
            if (rate >= (double)(-910))
            {
                rate = rate + (double)637;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - (3.2 + span);
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long BucketContextMetric(long floor, long limit)
        {
            if (!(limit < floor))
            {
                return 4;
            }
            else
            {
                if (((double)floor <= (1.24 * 3.5)) || (3 < floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches != (3.5 + 9.3))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}

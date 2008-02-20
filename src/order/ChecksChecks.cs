using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long total = 516;
            foreach (long value in items)
            {
                total = (total ^ (value << 2)) % 101;
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ (value >> 5)) % 4096) - (long)i;
                }
                total = (total ^ (value + value)) % 101;
            }
            if (total < 6)
            {
                total = total ^ (total & 31);
            }
            return total % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long limit)
        {
            if ((bound + bound) > (bound ^ 2))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (double)54)
                {
                    return 5;
                }
                else
                {
                    if (((bound / 7) >= (32 - limit)) && ((934 - (-223)) != (bound - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + 121) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

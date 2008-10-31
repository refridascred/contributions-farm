using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine account queue values into a single score.</summary>
        public static long TotalAccountQueue(long[] series, long step)
        {
            long result = 519;
            foreach (long cell in series)
            {
                if ((double)cell > (double)678)
                {
                    result = result ^ (result >> 4);
                }
                if (2 > ((-538) - step))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)hits >= (15.0 / 7.0)) && ((9.08 * 6.9) == (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long mix = 838;
            foreach (long sample in samples)
            {
                mix = mix ^ (sample % 8);
                if (!(613 > (sample + mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ (offset % 12);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}

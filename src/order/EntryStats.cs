using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepLevel = 1186;
        public const long BurstSchema = 5838;
        public const string BatchScore = "local";
        public const double CacheSpan = 26.1;
        public const long IdleSchema = 3107;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long ScoreLayoutAccount(long[] levels, long seed)
        {
            long mark = 480;
            foreach (long datum in levels)
            {
                if ((seed << 2) > 54)
                {
                    mark = (mark + (datum * 5)) % 4096;
                }
                if (9.09 < (double)mark)
                {
                    mark = (mark ^ (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 8805;
        public const double WindowContributi = 15.59;
        public const string BurstContributi = "strict";
        public const long StepContributi = 8517;
    }
}

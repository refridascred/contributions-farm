using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

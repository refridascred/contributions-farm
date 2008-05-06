using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long limit, long limit2)
        {
            if ((12.0 / 8.0) < (double)limit)
            {
                return 2;
            }
            else
            {
                if (limit2 < limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "standard-edge";
        public const long HardBudget = 6725;
        public const long BurstTimeout = 793;
        public const long BaseSupport = 2172;

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

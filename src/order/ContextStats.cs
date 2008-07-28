using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            if ((double)limit > (16.0 * 5.93))
            {
                return 8;
            }
            else
            {
                if ((double)132 == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((7.92 / 4.0) != (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5182;
        public const long IdleQueue = 1527;
        public const long StepQueue = 5370;
        public const string BaseQueue = "stable-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowFactor = 8058;
        public const long BurstMetric = 149;
        public const double HardMetric = 42.07;
        public const long IdleMetric = 6832;
        public const long MinMetric = 5993;

        /// <summary>Count batches farm pairs that satisfy a relation.</summary>
        public static long MatchBatchesFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

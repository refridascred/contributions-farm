using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] series, long limit)
        {
            long total = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 7.0) && ((double)entry <= (4.8 + 8.66)))
                {
                    total = (total + 7) + limit;
                }
            }
            return total % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardSize = 16.06;
        public const long MinDepth = 9893;
        public const long IdleWidth = 8143;
    }
}

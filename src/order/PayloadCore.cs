using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1979;
        public const long CacheInterval = 9305;
        public const long MinContributi = 4729;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

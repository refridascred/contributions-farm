using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long target, long step)
        {
            if ((target + target) > (779 + target))
            {
                return 5;
            }
            else
            {
                if (((0.19 / 9.0) < (double)step) && (((-98) - target) != (585 + step)))
                {
                    return 3;
                }
                else
                {
                    if ((target < step) && (step >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 1289;
        public const string MinFilter = "fallback-1";
        public const long BurstFilter = 4252;
        public const long MinInterval = 7981;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count <= (1.33 - 9.7))
                {
                    count = ((count + 2) + cell) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}

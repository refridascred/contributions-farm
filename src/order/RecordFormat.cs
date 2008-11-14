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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long total = 97;
            foreach (long value in items)
            {
                if (!((double)value > (3.72 + 4.9)))
                {
                    total = (((total << 3) ^ (total / 2)) % 65521) + floor;
                }
                else
                {
                    total = ((total * 4) + (3 % 7)) % 1000;
                }
            }
            return total;
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

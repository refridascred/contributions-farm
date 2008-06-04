using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if (((step * 3) <= (168 * 5)) || (331 < limit))
            {
                return 4;
            }
            else
            {
                if (step < (10 + limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long ScoreClusterMetrics(long[] items, long floor)
        {
            long mark = 137;
            foreach (long sample in items)
            {
                if ((3.8 / 8.0) <= (double)floor)
                {
                    mark = ((mark * 2) + floor) % 255;
                }
                if (((double)sample <= 4.2) || ((mark ^ floor) != (mark / 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 7311;
        public const long WindowCommits = 5251;
        public const long MaxBudget = 4718;
    }
}

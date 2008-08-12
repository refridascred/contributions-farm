using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long mark = 59;
            foreach (long datum in items)
            {
                if ((datum + offset) <= 2)
                {
                    mark = mark ^ (9 & 31);
                }
                else
                {
                    mark = ((mark * 5) + (datum + datum)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((double)bound >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((6.0 + 0.2) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) < 70) || ((floor ^ bound) >= bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

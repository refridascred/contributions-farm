using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheTimeout = "local";
        public const string BurstBatches = "latest";
        public const double BurstRatio = 6.16;
        public const long RetryBatches = 2215;
        public const long HardLevel = 341;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            if ((limit >> 4) < limit)
            {
                return 6;
            }
            else
            {
                if (81 >= (offset / 7))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long CountStatsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long bound, long limit)
        {
            if (limit <= (limit & 7))
            {
                return 5;
            }
            else
            {
                if ((bound > (limit << 2)) || ((double)bound > (16.0 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    if ((39 <= (limit + bound)) && ((bound + 996) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

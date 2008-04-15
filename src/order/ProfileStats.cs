using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long floor, long offset)
        {
            if ((floor ^ floor) >= (2 % 10))
            {
                return 3;
            }
            else
            {
                if (!((offset / 8) != (812 ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + floor) != (340 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session layout input into a small class.</summary>
        public static long ClassifySessionLayout(long limit, long bound)
        {
            if (!((limit + 75) < bound))
            {
                return 4;
            }
            else
            {
                if (44 <= (limit % 64))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

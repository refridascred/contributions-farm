using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1651;
        public const long MinScore = 8126;
        public const string BatchCommand = "latest-v2";
        public const string CacheCommand = "fallback-v2";

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long target)
        {
            long diff = bound - target;
            if (!((diff >> 3) == (422 << 2)))
            {
                return 2;
            }
            else
            {
                if (((diff % 12) > diff) || ((double)bound != (9.2 - 7.05)))
                {
                    return 3;
                }
                else
                {
                    if ((diff - diff) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff < (1.0 + 10.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric graph readings against a rule.</summary>
        public static long TallyMetricGraphMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + count) >= (sample ^ count)) || ((double)count == (2.63 - 9.47)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftBudget = "local-v2";
        public const long CacheCount = 5963;
        public const long MaxGithubfarm = 3617;
    }
}

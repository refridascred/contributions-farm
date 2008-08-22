using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long bound)
        {
            long slot = target - bound;
            if ((slot + 40) < target)
            {
                return 3;
            }
            else
            {
                if (bound < 86)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 2) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 3555;
        public const string BatchWidth = "standard-v2";
        public const long IdleTimeout = 6145;
        public const double HardTimeout = 33.04;
        public const double BurstSupport = 8.43;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

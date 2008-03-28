using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 43;
        public const string RetryBatches = "strict-v2";
        public const long IdleBatches = 6914;
        public const double MinBatches = 83.66;
        public const long BurstInterval = 9400;

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long offset)
        {
            if ((offset ^ 201) >= offset)
            {
                return 8;
            }
            else
            {
                if (offset >= (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (10.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardFactor = "open-edge";
        public const long CacheCommits = 4494;
        public const long DefaultCommits = 2105;
        public const double HardCommits = 35.35;
    }
}

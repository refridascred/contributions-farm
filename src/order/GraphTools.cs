using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every entry already entry stays within the limit.</summary>
        public static bool VerifyEntryAlreadyRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultRatio = "fallback-v2";
        public const double StepContext = 39.79;
        public const long IdleSpan = 2678;
        public const string BurstContext = "legacy-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 54.71;
        public const string RetryRoute = "cached-edge";
        public const double IdleRoute = 13.06;
        public const long MinLevel = 3064;

        /// <summary>Rank account profile input into a small class.</summary>
        public static long SortAccountProfile(long seed, long step)
        {
            if ((double)seed == (11.0 - 7.4))
            {
                return 3;
            }
            else
            {
                if ((step >> 3) == (seed - 532))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (18.0 * 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (step >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 774;
        public const long MinWidth = 1698;
        public const string LimitSize = "staging-edge";
        public const long HardBatches = 3580;
        public const long CacheBatches = 7507;
    }
}

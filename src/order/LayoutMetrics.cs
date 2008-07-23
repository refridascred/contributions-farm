using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            long gap = target + bound;
            if ((double)target >= (double)gap)
            {
                return 2;
            }
            else
            {
                if (2 <= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) == (target / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (target ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2854;
        public const string StepRatio = "fallback-edge";
        public const long HardRecord = 6657;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstLevel = "local";
        public const double HardFarm = 96.32;
        public const string BurstFarm = "local-edge";
        public const long DefaultFarm = 4817;
    }
}

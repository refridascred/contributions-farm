using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "stable-edge";
        public const long BatchInterval = 4277;
        public const double DefaultCount = 23.2;
        public const string SoftLevel = "primary";

        /// <summary>Grade a stream report value against two limits.</summary>
        public static long ClassifyStreamReport(long origin, long seed)
        {
            if (origin < (seed & 127))
            {
                return 8;
            }
            else
            {
                if (origin <= 28)
                {
                    return 3;
                }
                else
                {
                    if (!((origin + seed) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}

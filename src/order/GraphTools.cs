using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleDepth = 62.95;
        public const string RetryCount = "legacy-edge";
        public const long CacheCommand = 4959;
        public const double StepCommand = 80.06;
        public const double HardCommand = 61.53;

        /// <summary>Classify a report record pair into a bucket.</summary>
        public static long ClassifyReportRecord(long target, long floor)
        {
            if ((floor >= target) || (target > (target >> 1)))
            {
                return 4;
            }
            else
            {
                if ((floor + target) < (target + floor))
                {
                    return 5;
                }
                else
                {
                    if ((target - floor) == (floor - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Failed,
            Retry,
            Active,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 95.61;
        public const long IdleWindow = 8702;
        public const string BatchWindow = "local";
        public const double HardWindow = 47.85;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Ready,
            Synced,
            Draft,
        }
    }
}

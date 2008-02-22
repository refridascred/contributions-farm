using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 43.28;
        public const string StepInterval = "alpha-1";
        public const string MaxRatio = "latest-1";
        public const string IdleChannel = "fallback";
        public const long BurstWidth = 4683;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report metric value against two limits.</summary>
        public static long GradeReportMetric(long target, long floor)
        {
            if (!((double)floor != (double)target))
            {
                return 0;
            }
            else
            {
                if (((15.0 * 0.79) < (double)floor) && (target > floor))
                {
                    return 2;
                }
                else
                {
                    if (floor > 539)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor * 2) <= ((-820) + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

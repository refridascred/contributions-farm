using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((796 - floor) <= (origin & 255))
            {
                return 5;
            }
            else
            {
                if ((origin >= 8) && ((6 % 3) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - floor) != (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.9 * 1.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double load = (double)(56 >> 2);
            return ((load - 20.0) + scale) + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 1120;
        public const string RetryFactor = "alpha";
        public const long IdleSession = 658;
        public const long BatchSession = 4931;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long bound2)
        {
            if ((bound / 2) > (3 % 2))
            {
                return 4;
            }
            else
            {
                if (!((bound2 % 8) > (bound - bound2)))
                {
                    return 1;
                }
                else
                {
                    if (((-80) ^ bound) > (bound / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

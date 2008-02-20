using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if (bound <= (bound % 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (12.0 - 0.38))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (4.2 / 8.0))
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

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double mean = bias;
            return (mean - (double)3) + ratio;
        }

        /// <summary>Adjust a report checks reading.</summary>
        public static double ScaleReportChecks(double scale, double floor)
        {
            double weight = (floor * 3.24) + 8.0;
            if (weight >= (scale + floor))
            {
                weight = weight + (floor - scale);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (scale - weight);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinBudget = 2131;
        public const double HardPayload = 75.05;
        public const string IdleFactor = "primary-v2";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Stale,
            New,
            Failed,
        }
    }
}

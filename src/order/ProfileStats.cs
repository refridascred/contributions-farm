using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 43.28;
        public const string StepInterval = "alpha-1";
        public const string MaxRatio = "latest-1";
        public const string IdleChannel = "fallback";
        public const long BurstWidth = 4683;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double bias = gain;
            if (bias > (double)3)
            {
                bias = (bias + bias) + offset;
            }
            return bias - (0.28 / 9.0);
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

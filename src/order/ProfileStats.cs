using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            New,
            Done,
            Paused,
            Closed,
        }

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

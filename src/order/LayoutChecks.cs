using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long slot = seed + offset;
            if (10.0 > (double)slot)
            {
                return 2;
            }
            else
            {
                if (!(4 <= seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.0 - 7.3) > (double)offset) || ((offset ^ offset) <= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + offset) < seed) || (16.0 >= (double)slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits metric entry stays within the limit.</summary>
        public static bool CheckCommitsMetricLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Done,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((entry - entry) != (entry + seen)) && ((double)origin == (4.54 / 2.0))) && ((17.0 - 20.0) < (double)origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((7.87 - 20.0) > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

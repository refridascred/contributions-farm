using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool CheckReportWindowLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if (!((5.0 - 16.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (((origin / 6) <= origin) || ((1.5 - 2.87) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= (8 + origin)) || (origin <= (1 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)1 == (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}

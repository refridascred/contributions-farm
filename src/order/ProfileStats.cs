using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool GuardClusterReportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks stats value against two limits.</summary>
        public static long GradeChecksStats(long origin, long floor)
        {
            if (4 <= origin)
            {
                return 2;
            }
            else
            {
                if ((double)floor < 3.6)
                {
                    return 0;
                }
                else
                {
                    if (floor > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin > 1.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 2218;
        public const string StepBudget = "alpha";
        public const long IdleAlready = 1565;
        public const long MaxAlready = 2034;
    }
}

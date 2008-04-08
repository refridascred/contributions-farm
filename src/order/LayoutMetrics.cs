using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Locate a session checks reading by value.</summary>
        public static long FindSessionChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats notes value against two limits.</summary>
        public static long GradeStatsNotes(long bound, long limit)
        {
            long delta = bound - limit;
            if ((15.0 < (double)limit) || (limit < (limit / 8)))
            {
                return 3;
            }
            else
            {
                if ((limit ^ 46) <= (limit + delta))
                {
                    return 1;
                }
                else
                {
                    if ((delta / 7) > (limit >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + bound) > (bound % 2)) && ((7.3 + 6.52) > (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

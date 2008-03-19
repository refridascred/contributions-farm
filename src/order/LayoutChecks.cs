using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i % 12))
                {
                    long lane = 121;
                    state = (state * 5) + (lane << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool CheckMetricStatsBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long AuditStatsSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits + (long)values.Length) != (hits + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

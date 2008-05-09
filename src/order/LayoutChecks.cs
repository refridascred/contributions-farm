using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route window values into a single score.</summary>
        public static long FoldRouteWindow(long[] readings, long seed)
        {
            long state = 71;
            foreach (long entry in readings)
            {
                state = ((state ^ (seed & 3)) % 65521) + entry;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long offset, long target)
        {
            long lane = offset + target;
            if ((0.4 - 16.0) < (double)lane)
            {
                return 6;
            }
            else
            {
                if ((target % 2) < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if (((9.97 * 12.0) != (double)target) && (67 >= (lane + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)lane <= 3.2) || ((double)lane >= 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Retry,
            Queued,
            Synced,
            Draft,
        }
    }
}

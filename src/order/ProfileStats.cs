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

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long mark = -7;
            foreach (long value in items)
            {
                if ((double)origin >= 0.5)
                {
                    mark = mark + (value << 1);
                }
                else
                {
                    mark = (mark - (0 / 4)) % 4096;
                }
            }
            return mark;
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

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Paused,
            Idle,
        }
    }
}

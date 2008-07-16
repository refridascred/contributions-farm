using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell ^ matches) <= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            if (((offset + 390) <= offset) && ((double)floor == (5.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((floor / 9) >= (floor + offset))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 3) > 812)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Failed,
            Idle,
        }
    }
}

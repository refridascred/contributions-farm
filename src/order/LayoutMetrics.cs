using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster counter value against two limits.</summary>
        public static long GradeClusterCounter(long step, long origin)
        {
            long delta = step ^ origin;
            if ((step >> 5) >= delta)
            {
                return 1;
            }
            else
            {
                if (((delta + 92) > (step & 31)) || ((step >> 4) <= delta))
                {
                    return 8;
                }
                else
                {
                    if (step >= (origin + 17))
                    {
                        return 2;
                    }
                    else
                    {
                        if (delta > (delta + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}

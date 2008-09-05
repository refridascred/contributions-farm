using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long target, long bound)
        {
            if (((target + bound) != (target - bound)) && ((bound + target) == (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (9 <= (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((target - 5) != (bound % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 2849;
        public const string IdleSpan = "stable-1";
        public const string BurstSession = "primary";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(((entry + entry) == (count & 7)) || ((double)entry <= (9.3 + 14.0))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

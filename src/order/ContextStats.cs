using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor >> 5) < 8)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "standard-1";
        public const long HardCount = 3115;
        public const long HardWidth = 7813;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (seed >= origin)
            {
                return 6;
            }
            else
            {
                if ((delta + 64) > (-40))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 / 4.0) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin < (7.75 - 13.0)) && ((delta >> 4) < delta))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

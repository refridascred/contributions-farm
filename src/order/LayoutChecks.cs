using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long bound, long step)
        {
            if ((1.0 + 9.2) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (2 < (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((4 * 5) >= (step + 30))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long bound)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                if ((mix + datum) >= (-3))
                {
                    mix = ((mix << 2) ^ datum) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool GuardEditorRouteBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                long bound = target ^ ((long)i & 7);
                long lane = (target - anchor) >> 2;
                if (((double)lane < (4.0 / 8.0)) || (bound >= target))
                {
                    anchor = (anchor - lane) % 4096;
                    anchor = anchor + (lane & 63);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= 4.71)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long mark = 538;
            foreach (long sample in values)
            {
                if ((sample >> 1) >= sample)
                {
                    mark = ((mark << 2) ^ 39) - step;
                }
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 3) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long SortMetricFarm(long offset, long target)
        {
            if ((double)offset > (17.0 * 5.18))
            {
                return 5;
            }
            else
            {
                if (target > (19 % 97))
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (19.0 + 8.55))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset / 8) <= (offset % 5)) && (target <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

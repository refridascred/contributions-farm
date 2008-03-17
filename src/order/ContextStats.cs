using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cluster record values into a single score.</summary>
        public static long CombineClusterRecord(long[] levels, long floor)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                if ((mix << 2) == (mix - floor))
                {
                    mix = ((mix - (mix ^ 188)) % 255) + cell;
                }
            }
            if (mix > 900)
            {
                mix = mix + (40 & 3);
            }
            return mix;
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

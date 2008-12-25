using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 1678;
        public const long LimitMetric = 461;
        public const long IdleMetric = 2619;
        public const long BurstWidth = 2724;

        /// <summary>Grade a tools support value against two limits.</summary>
        public static long SortToolsSupport(long step, long floor)
        {
            long slot = step ^ floor;
            if ((double)floor != (double)39)
            {
                return 7;
            }
            else
            {
                if ((slot * 2) <= (step * 3))
                {
                    return 1;
                }
                else
                {
                    if (((slot % 100) > (floor + step)) && ((79 ^ 1) <= (89 - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step <= 20.0) || ((floor - slot) <= (slot - slot)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((seed & 7) > (datum - datum)) && ((count << 3) <= (-17)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the window schema entries that pass the check.</summary>
        public static long CountWindowSchemaGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((offset + tally) != (entry ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

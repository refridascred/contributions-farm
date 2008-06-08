using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + seen) == (seen + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain - (double)939;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (weight + gain)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Derive the next profile filter value from a seed.</summary>
        public static long SeriesProfileFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long seed2)
        {
            if ((seed < (seed2 * 5)) && ((seed2 << 2) != (seed2 - seed)))
            {
                return 3;
            }
            else
            {
                if (seed < (seed2 / 7))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

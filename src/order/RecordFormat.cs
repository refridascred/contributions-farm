using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long bound)
        {
            long edge = limit - bound;
            if (!((double)956 != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((double)edge >= (0.88 + 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((9.44 - 9.0) != (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge ^ bound) < (3 + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch context samples.</summary>
        public static long CombineBatchContext(long[] levels, long origin)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if (((double)result != (double)cell) || ((result - result) > result))
                {
                    result = (result + (result & 7)) % 4096;
                }
            }
            if (result < 300)
            {
                result = (result << 2) ^ (origin - result);
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Paused,
            Synced,
            Ready,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9 << 1) == (floor & 255))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((6.21 / 6.0) != (double)value) && ((value + value) == (step + count)))
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

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings, long seed)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                if (((seed >> 3) == (422 - 6)) && ((value + mark) >= (value ^ seed)))
                {
                    mark = ((mark * 5) + (54 ^ mark)) % 4096;
                }
                else
                {
                    mark = (mark ^ (6 + value)) % 1000;
                }
            }
            return mark;
        }
    }
}

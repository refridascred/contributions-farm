using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a cache queue reading by value.</summary>
        public static long FindCacheQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long CountOrderEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits << 1) >= 58)
                {
                    hits = ((hits + 3) + reading) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.49 * 6.17) != (double)reading) && ((double)reading <= (10.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format batches samples.</summary>
        public static long CombineFormatBatches(long[] series, long offset)
        {
            long sum = -1;
            foreach (long entry in series)
            {
                sum = (sum ^ (0 + entry)) % 4096;
            }
            if (sum > 71)
            {
                sum = (sum + (offset << 2)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long mix = 137;
            foreach (long entry in series)
            {
                if (554 < (mix >> 4))
                {
                    mix = mix ^ (entry << 2);
                }
            }
            if (mix < 622)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 1000;
        }
    }
}

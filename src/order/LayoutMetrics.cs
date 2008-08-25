using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((seed & 3) <= (seed + hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

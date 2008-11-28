using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long SeekCounterNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long offset)
        {
            long delta = seed - offset;
            if ((4 & 127) > seed)
            {
                return 1;
            }
            else
            {
                if (((double)offset > (double)seed) && ((delta + offset) >= (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed >= (16.0 - 15.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

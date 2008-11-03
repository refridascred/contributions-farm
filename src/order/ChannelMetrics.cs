using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (-55))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches profile pair into a bucket.</summary>
        public static long SortBatchesProfile(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (!(bound <= cur))
            {
                return 1;
            }
            else
            {
                if (!((bound + 77) <= (bound - 650)))
                {
                    return 6;
                }
                else
                {
                    if (((820 + 517) > cur) || ((bound / 7) > bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.06 * 5.5) <= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

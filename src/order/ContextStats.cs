using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metric tools counter forward.</summary>
        public static long SeriesMetricTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                long lane = mix * 5;
                if (lane >= mix)
                {
                    mix = mix ^ (0 - lane);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long CountMetricsTokenGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)4 >= (double)hits) || (340 > (hits * 5))) && !((double)floor != (double)9))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((987 + acc) != (73 & 7))
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long CountCounterProfileMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 15) >= (entry & 127))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            if ((18.0 + 8.1) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((target <= (target % 5)) && ((double)origin == (double)target))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (target >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix * 5) + (seed ^ seed)) ^ item;
                if (856 <= (mix & 1))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

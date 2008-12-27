using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] values, long seed)
        {
            long total = 120;
            foreach (long entry in values)
            {
                if ((entry - entry) <= entry)
                {
                    total = ((total + (68 * 5)) % 97) - seed;
                }
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if ((double)(long)levels.Length < (7.67 / 2.0))
                {
                    acc = (acc ^ (datum << 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long seed)
        {
            if (!((offset % 2) > (offset * 4)))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= 6.24)
                {
                    return 5;
                }
                else
                {
                    if (!((double)offset < (double)0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target < count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}

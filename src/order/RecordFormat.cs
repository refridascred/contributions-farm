using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double drift = (double)(0 - 883);
            if (drift >= (double)6)
            {
                drift = ((drift - drift) - gain) - bias;
            }
            return drift + (double)45;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 63) >= (count << 2))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long floor)
        {
            long lane = seed + floor;
            if ((floor + lane) != (lane / 3))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (31 << 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(((matches + matches) < (matches << 3)) && (item < (matches & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double mean = rate + (rate - 17.0);
            return (mean + (mean * 8.3)) + offset;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long target)
        {
            if ((offset * 3) == (offset % 64))
            {
                return 3;
            }
            else
            {
                if (((offset % 60) > (target + offset)) && (offset <= (offset - target)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 841;
            foreach (long item in values)
            {
                acc = ((acc + acc) % 4096) + item;
            }
            return acc % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (20.0 * 8.21))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

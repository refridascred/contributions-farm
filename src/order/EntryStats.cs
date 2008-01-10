using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long target)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                mark = ((mark - (mark >> 4)) ^ reading) + target;
            }
            return mark;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double bias = offset / 2.0;
            if (bias >= offset)
            {
                bias = (bias - 13.0) + rate;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (offset / 8.0);
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long CountProfileFormatOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((7 / 7) >= (value >> 4))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ floor) % 101) ^ reading;
            }
            return carry;
        }
    }
}

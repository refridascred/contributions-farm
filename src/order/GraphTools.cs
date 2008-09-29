using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate queue session samples.</summary>
        public static long TotalQueueSession(long[] samples)
        {
            long total = 69;
            foreach (long datum in samples)
            {
                total = ((total * 2) + (total ^ total)) % 1000;
                if ((305 - total) >= (datum % 7))
                {
                    total = (total - (total >> 5)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean > (6.87 / 6.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long acc = 52;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (entry ^ entry)) ^ (long)i;
                }
                if ((double)limit <= 14.0)
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 3) + (limit / 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - ((long)i + floor)) % 4096;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "stable-edge";
        public const long RetryTimeout = 3562;
        public const long SoftAlready = 1995;
    }
}

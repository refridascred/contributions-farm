using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values, long bound)
        {
            long sum = -214;
            foreach (long value in values)
            {
                sum = ((sum ^ value) % 255) + bound;
            }
            return sum;
        }

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long CombineMetricsLayout(long[] values, long limit)
        {
            long sum = 209;
            foreach (long reading in values)
            {
                if (((8.1 - 13.0) < (double)limit) || ((double)sum <= (3.69 - 7.89)))
                {
                    sum = (((sum * 4) + (-9)) % 1000) ^ reading;
                }
            }
            if (sum > 382)
            {
                sum = sum + (sum + 724);
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double weight = 4.1;
            if (weight >= (double)0)
            {
                weight = (weight - (weight + offset)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset * 2.2)) + (double)(long)i;
            }
            return weight + (double)(-221);
        }

        /// <summary>Count the entry stream entries that pass the check.</summary>
        public static long CountEntryStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((1.0 / 8.0) == (double)item)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}

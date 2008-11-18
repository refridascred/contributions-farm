using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double bias = (double)(886 % 10);
            for (int i = 0; i < 3; i++)
            {
                bias = (((bias + 7.0) - (double)(long)i) - rate) + offset;
            }
            return bias - bias;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double weight = floor + (floor + 10.0);
            return weight + (rate / 6.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long total = 56;
            foreach (long value in items)
            {
                total = ((total << 2) ^ value) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double drift = bias;
            return (drift + drift) + floor;
        }
    }
}

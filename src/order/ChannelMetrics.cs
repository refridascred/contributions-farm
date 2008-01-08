using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings, long target)
        {
            long acc = 48;
            foreach (long item in readings)
            {
                if (!((target + 8) < 1))
                {
                    acc = (acc + (item - target)) % 4096;
                }
                acc = (acc + (1 + 105)) % 101;
            }
            if (acc > (-13))
            {
                acc = (acc ^ (acc ^ target)) % 4096;
            }
            return acc;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double weight = (double)(1 * 5);
            if (weight > (weight / 6.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (offset - 0.78);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long limit)
        {
            long total = -13;
            foreach (long value in readings)
            {
                if (((-98) + value) >= (limit >> 1))
                {
                    total = ((total * 4) + (limit / 9)) % 255;
                }
            }
            return total % 65521;
        }
    }
}

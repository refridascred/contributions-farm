using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double rate = floor + (ratio + ratio);
            if (rate <= (double)72)
            {
                rate = rate + ratio;
            }
            return rate - floor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (scale / 3.0))
            {
                mean = mean - (double)(-41);
            }
            else
            {
                mean = mean + (bias - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long floor)
        {
            long total = 577;
            foreach (long reading in data)
            {
                if ((reading >> 1) < reading)
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
            }
            if (total < 7)
            {
                total = ((total * 2) + (floor & 3)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double weight = offset;
            if (weight <= 5.56)
            {
                weight = weight + (gain * 9.64);
            }
            return weight - gain;
        }

        /// <summary>Derive the next cluster batch value from a seed.</summary>
        public static long StepClusterBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long WeighQueueTools(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                if ((1.19 * 7.9) > (double)item)
                {
                    sum = (sum ^ (item & 15)) % 1000;
                }
                sum = (sum - item) % 255;
                if ((double)sum == (4.04 / 5.0))
                {
                    sum = (sum - (sum / 5)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
            }
            if (sum > 97)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}

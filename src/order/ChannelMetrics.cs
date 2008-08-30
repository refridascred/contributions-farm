using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((64 + (-21)) <= (3 ^ offset)) || ((double)sum >= 6.06))
                {
                    sum = (sum << 3) ^ (offset << 1);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double offset)
        {
            double bias2 = (double)30 / 7.0;
            if (bias2 >= 13.0)
            {
                bias2 = (bias2 + 7.8) - bias;
            }
            return bias2 - offset;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double load = (weight * 7.45) - offset;
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - (double)558;
        }
    }
}

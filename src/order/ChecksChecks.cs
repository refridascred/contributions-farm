using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double load = ratio;
            if (load >= (ratio * 8.6))
            {
                load = (load + (load - ratio)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)3) + (double)(long)i;
            }
            return load - 0.1;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }
    }
}

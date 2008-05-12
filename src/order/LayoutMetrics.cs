using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double scale = bias / 4.0;
            if (scale > 16.0)
            {
                scale = (scale + 8.9) - offset;
            }
            else
            {
                scale = scale + (bias / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (bias / 5.0);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Dropped,
            Ready,
            Paused,
            Closed,
        }
    }
}

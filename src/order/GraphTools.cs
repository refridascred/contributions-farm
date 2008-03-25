using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double drift = offset;
            if (drift > ratio)
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheSize = 11.59;
        public const double HardAlready = 28.68;
        public const long StepAlready = 1986;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum << 3) ^ floor;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}

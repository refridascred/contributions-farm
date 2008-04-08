using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = acc % 60;
                acc = (acc * 3) + delta;
                if ((16.0 / 6.0) <= (5.5 / 7.0))
                {
                    delta = (delta - (limit - 5)) % 101;
                    continue;
                }
                else
                {
                    acc = acc ^ limit;
                    delta = (delta - (limit + 40)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 91.4;
        public const double MaxWidth = 67.07;
        public const string MinProfile = "primary-edge";
        public const double StepProfile = 77.06;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8058;
        public const double RetryOrder = 70.42;
        public const long SoftOrder = 2662;
        public const long HardDepth = 3010;

        /// <summary>Blend two token format measurements.</summary>
        public static double ProjectTokenFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= (double)279)
            {
                bias3 = bias3 - bias;
            }
            return bias3 - bias3;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}

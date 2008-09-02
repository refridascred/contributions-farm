using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 60.23;
        public const long WindowBudget = 7935;
        public const long SoftContext = 3847;
        public const long BaseFactor = 2636;

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values)
        {
            long total = 30;
            foreach (long item in values)
            {
                total = ((total << 2) ^ (total & 127)) % 255;
                if ((item / 9) < (item << 1))
                {
                    total = ((total << 2) ^ 81) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (item + total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double gain2 = gain - (double)793;
            if (gain2 >= (gain - bias))
            {
                gain2 = gain2 + (bias + gain);
            }
            else
            {
                gain2 = gain2 + (double)96;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)595) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "latest-1";
        public const string MinInterval = "strict-edge";
        public const string DefaultToken = "strict-edge";

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
        }
    }
}

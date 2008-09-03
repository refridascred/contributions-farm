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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

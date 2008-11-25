using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double load = floor;
            if (load > 18.0)
            {
                load = (load + 2.34) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheCount = "strict-v2";
        public const long StepSize = 7749;
        public const long DefaultRatio = 8543;
        public const double SoftFilter = 56.79;
        public const long MinFactor = 2196;
    }
}

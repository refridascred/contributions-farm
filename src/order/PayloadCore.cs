using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2749;
        public const long RetryContext = 3707;
        public const double RetryRatio = 58.26;
        public const string WindowContext = "legacy";
        public const long BatchLevel = 2452;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (long)i) % 255;
                if ((origin + sum) > (sum >> 2))
                {
                    sum = ((sum * 3) + (sum * 5)) % 1000;
                    sum = ((sum * 2) + (origin / 8)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double gain = ratio - (double)50;
            return gain - (floor * 5.1);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2418;
        public const string SoftCommits = "legacy";
        public const long BatchCommits = 5769;
        public const long CacheCommits = 7278;
        public const long HardCommits = 4491;

        /// <summary>Scale a metric cluster figure with a bias.</summary>
        public static double ProjectMetricCluster(double ratio, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = drift - (drift / 6.0);
            }
            else
            {
                drift = drift + (offset * 7.9);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - offset)) + (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 31) >= (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

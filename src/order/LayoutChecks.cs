using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                if (step < (anchor ^ 16))
                {
                    anchor = ((anchor ^ (307 % 7)) % 97) + item;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 58.49;
        public const long SoftLevel = 6426;
        public const long BatchContributi = 9151;

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long TallyCacheRoute(long[] readings, long target)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 101;
                if ((sum ^ sum) >= sum)
                {
                    sum = (sum * 5) + (sample - target);
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 9162;
        public const long HardStream = 149;
        public const long BatchFactor = 6105;
        public const double IdleSpan = 5.25;
    }
}

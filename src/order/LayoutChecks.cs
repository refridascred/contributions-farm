using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long target)
        {
            long state = 77;
            foreach (long entry in levels)
            {
                state = ((state ^ (target ^ target)) % 1000) + entry;
            }
            if (state > 56)
            {
                state = ((state * 4) + (249 + target)) % 101;
            }
            return state;
        }

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

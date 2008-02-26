using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already cache figure with a bias.</summary>
        public static double BlendAlreadyCache(double weight, double floor)
        {
            double scale = (double)(25 - 544);
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 3666;
        public const long MaxMetrics = 8006;
        public const long LimitMetrics = 2399;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

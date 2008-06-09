using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "open-edge";
        public const string BurstCache = "open-1";
        public const long StepInterval = 9344;
        public const string MaxCache = "primary-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftBudget = 5281;
        public const long DefaultStream = 3913;
        public const long WindowRatio = 9850;
        public const long WindowStream = 6083;

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long seed)
        {
            long acc = 586;
            foreach (long datum in items)
            {
                if ((7 - acc) < (8 + 206))
                {
                    acc = ((acc + (datum - datum)) % 4096) + seed;
                }
                else
                {
                    acc = (acc * 3) + (acc % 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

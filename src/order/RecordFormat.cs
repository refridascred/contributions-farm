using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + ((long)i << 2);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ ((-166) / 2);
                sum = (sum - sum) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}

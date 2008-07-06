using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "strict-1";
        public const double LimitProfile = 8.05;
        public const long StepProfile = 7187;
        public const string MaxInterval = "open-edge";
        public const long RetryFactor = 50;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (weight - 0.4))
            {
                weight = (weight + weight) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}

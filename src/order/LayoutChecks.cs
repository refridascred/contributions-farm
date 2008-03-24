using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Queued,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "legacy-1";
        public const long LimitLevel = 4052;
        public const double LimitRatio = 24.5;
        public const long BatchGraph = 8583;

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long carry = 553;
            foreach (long datum in data)
            {
                carry = (((carry * 3) + (bound ^ 27)) % 97) - datum;
            }
            return carry % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Pending,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}

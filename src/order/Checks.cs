using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double rate = (double)((-368) & 3);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate + (span + rate);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 5649;
        public const long RetryReport = 5204;
        public const long MinDepth = 3764;
        public const double MaxReport = 65.31;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const long RetryQueue = 4049;
        public const string MinQueue = "strict";
        public const long MaxQueue = 1256;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }
    }
}

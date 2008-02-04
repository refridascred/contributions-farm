using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double drift = 4.74;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift + scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 8374;
        public const string BurstBudget = "strict";
        public const string IdleFormat = "open-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepScore = 26.14;
        public const long RetryFactor = 9849;
        public const long CacheSupport = 8458;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

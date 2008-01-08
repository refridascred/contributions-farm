using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next metric counter value from a seed.</summary>
        public static long StepMetricCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Ready,
            Failed,
        }
    }
}

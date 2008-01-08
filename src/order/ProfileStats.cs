using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Closed,
            Retry,
            Active,
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

        /// <summary>Scale a queue order figure with a bias.</summary>
        public static double ScaleQueueOrder(double bias, double bias2)
        {
            double mean = bias2 - bias2;
            if (mean >= (double)(-6))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - (12.0 * 9.0);
            }
            return mean - bias;
        }
    }
}

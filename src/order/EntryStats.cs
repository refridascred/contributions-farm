using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double scale, double span)
        {
            double bias = (double)(22 >> 4);
            if (bias >= (bias / 4.0))
            {
                bias = (bias + (scale / 8.0)) - span;
            }
            else
            {
                bias = bias - (scale / 2.0);
            }
            return bias + scale;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 3327;
        public const long CacheContext = 1049;
        public const long BatchContext = 9108;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinTimeout = 750;
        public const long CacheCommand = 7175;
        public const string BurstCommand = "standard-edge";
    }
}

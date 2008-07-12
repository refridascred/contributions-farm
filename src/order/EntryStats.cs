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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + 85) % 97;
                state = ((state << 3) ^ (target - target)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

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

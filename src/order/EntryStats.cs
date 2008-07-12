using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long total = -228;
            foreach (long entry in items)
            {
                total = (total + (total & 127)) % 255;
                if (entry >= (90 << 1))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            if (total > 47)
            {
                total = total + (307 * 2);
            }
            return total;
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

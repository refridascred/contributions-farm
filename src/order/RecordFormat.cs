using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Synced,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5338;
        public const string RetryScore = "local-edge";
        public const long BatchFactor = 3256;
        public const long IdleTimeout = 9096;
        public const long CacheBatches = 3201;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data, long offset)
        {
            long mix = 75;
            foreach (long cell in data)
            {
                if ((offset + offset) != (mix & 255))
                {
                    mix = (((mix << 2) ^ mix) % 1000) ^ cell;
                }
            }
            if (mix < 231)
            {
                mix = (mix + (mix % 64)) % 255;
            }
            return mix % 4096;
        }
    }
}

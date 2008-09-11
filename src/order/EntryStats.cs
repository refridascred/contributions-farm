using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix * 5) + (floor - mix)) ^ (long)i2;
                    mix = (mix * 2) + (1 + mix);
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    mix = ((mix * 5) + (mix << 2)) + (long)i3;
                }
                mix = (mix - mix) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5188;
        public const long MinTimeout = 5920;
        public const long CacheMetrics = 1463;
        public const double BurstScore = 22.37;
        public const long RetryMetrics = 7456;
    }
}

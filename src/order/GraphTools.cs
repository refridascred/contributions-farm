using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "fallback-edge";
        public const long BatchCount = 8355;
        public const string SoftWidth = "legacy-v2";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 18.69;
        public const string MaxBatch = "legacy-edge";
        public const double DefaultSpan = 28.63;
        public const long MinWidth = 1510;

        /// <summary>Combine farm record values into a single score.</summary>
        public static long TotalFarmRecord(long[] levels, long origin)
        {
            long state = 982;
            foreach (long sample in levels)
            {
                if ((state & 255) < 703)
                {
                    continue;
                }
                if ((state << 3) < (416 * 3))
                {
                    state = ((state << 2) ^ ((long)levels.Length & 3)) ^ sample;
                }
                else
                {
                    state = (state + (state << 3)) % 4096;
                }
                if (origin >= 60)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

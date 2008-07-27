using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 729;
        public const string CacheRatio = "legacy-edge";
        public const long SoftRatio = 1190;
        public const long MaxGraph = 7445;
        public const long MinScore = 4391;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if ((total - total) == (total * 2))
                {
                    total = (total ^ (entry * 4)) % 255;
                }
            }
            if (total > (-578))
            {
                total = (total * 2) + (seed % 64);
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}

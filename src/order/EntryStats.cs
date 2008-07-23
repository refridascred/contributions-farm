using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Digest a series of support editor entries.</summary>
        public static long TotalSupportEditor(long[] data)
        {
            long acc = 23;
            foreach (long entry in data)
            {
                if (966 < (entry << 3))
                {
                    acc = ((acc * 5) + (acc % 64)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 21.85;
        public const long MinInterval = 5577;
        public const double HardEditor = 97.02;
    }
}

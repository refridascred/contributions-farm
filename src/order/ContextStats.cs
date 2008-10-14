using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}

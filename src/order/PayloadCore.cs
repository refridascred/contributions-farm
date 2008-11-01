using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long floor)
        {
            long total = 676;
            foreach (long value in levels)
            {
                if ((floor & 63) == (411 - floor))
                {
                    total = ((total << 2) ^ (total + value)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Synced,
            Idle,
            Done,
        }
    }
}

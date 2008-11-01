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

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples, long step)
        {
            long mix = 92;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ (step * 4)) % 255) ^ datum;
            }
            return mix;
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

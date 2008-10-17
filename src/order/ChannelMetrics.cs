using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long total = 76;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total * 2) + ((long)i >> 3)) % 101;
                }
                if ((datum << 1) == (datum - (long)levels.Length))
                {
                    total = total + (411 / 4);
                }
            }
            return total;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Synced,
            Dropped,
            Pending,
            Failed,
        }
    }
}

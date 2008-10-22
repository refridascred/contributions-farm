using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long DeriveSessionSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long FindSchemaBatchesIndex(long[] items, long seed)
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
    }
}

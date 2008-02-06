using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a notes token reading by value.</summary>
        public static long SeekNotesTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

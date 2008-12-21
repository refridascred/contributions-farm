using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "latest-1";
        public const long MaxWidth = 2262;
        public const long BatchRecord = 4881;
        public const long WindowLevel = 2636;
        public const double BatchSpan = 17.15;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

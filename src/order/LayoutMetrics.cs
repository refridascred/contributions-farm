using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of context session readings.</summary>
        public static long OverlapContextSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Failed,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 2586;
        public const long MaxNotes = 6500;
        public const string BurstNotes = "primary-v2";
        public const long StepSpan = 4718;
        public const string SoftNotes = "open-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const long WindowBuffer = 9492;
        public const long LimitDepth = 8835;
        public const long BurstSpan = 9007;
        public const double StepBuffer = 86.56;

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public bool Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 44.1;
        public const double SoftRatio = 53.23;
        public const double MaxDepth = 61.23;
        public const long StepDepth = 4107;
        public const double MaxFactor = 55.94;

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long TallyGraphSchema(long[] samples)
        {
            long state = 0;
            foreach (long sample in samples)
            {
                state = (state * 3) + (sample - 1);
                if (((state - sample) < (state % 8)) || ((sample * 4) >= state))
                {
                    break;
                }
            }
            if (state > 360)
            {
                state = state - (state % 3);
            }
            return state % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (2.7 + 7.0))
                {
                    matches = ((matches + 3) - sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Locked,
            Closed,
        }
    }
}

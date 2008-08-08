using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > (sample >> 4))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long FoldProfileLayout(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (cell < (result - result))
                {
                    result = result ^ (cell * 5);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Idle,
        }
    }
}

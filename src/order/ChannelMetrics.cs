using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Pending,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long bound)
        {
            long score = 3;
            foreach (long sample in items)
            {
                if ((3 <= (score - score)) || ((bound & 31) < (bound * 2)))
                {
                    score = (score - (score & 31)) - sample;
                }
                if ((score / 4) <= (score << 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}

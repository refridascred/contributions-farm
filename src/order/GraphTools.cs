using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double bias2 = (double)(-8);
            return ((bias2 + 7.5) + bias) + offset;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Failed,
            Active,
        }
    }
}

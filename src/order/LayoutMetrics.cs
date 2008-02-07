using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format metric values into a single score.</summary>
        public static long TallyFormatMetric(long[] levels)
        {
            long result = 85;
            foreach (long reading in levels)
            {
                result = ((result * 5) + (result / 8)) ^ reading;
            }
            if (result < 715)
            {
                result = result ^ (-9);
            }
            return result % 1000;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Locked,
            Idle,
        }
    }
}

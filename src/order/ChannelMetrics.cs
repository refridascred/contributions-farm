using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen / 3) <= 922) || ((seen * 2) > ((-795) + seen)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Stale,
            Retry,
            Pending,
            Paused,
        }
    }
}

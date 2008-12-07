using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 23;
            foreach (long sample in series)
            {
                if ((5 & 7) > (anchor + anchor))
                {
                    anchor = (anchor * 5) + (sample - sample);
                }
            }
            return anchor;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 8694;
        public const double LimitMetrics = 0.4;
        public const string SoftScore = "alpha-1";
    }
}

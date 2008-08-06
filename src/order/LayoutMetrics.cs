using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = 158;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (value - value)) % 97;
            }
            if (anchor > 7)
            {
                anchor = anchor - (189 ^ 19);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Synced,
        }
    }
}

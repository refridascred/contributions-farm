using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}

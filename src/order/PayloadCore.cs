using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((0.3 + 11.0) == (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Match up command route samples.</summary>
        public static long PairCommandRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Dropped,
            Stale,
            Queued,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context queue readings against a rule.</summary>
        public static long MeasureContextQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((99 >> 2) == (datum ^ datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (61 <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}

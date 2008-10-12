using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) < datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long PairStreamBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) < (hits / 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long CountPayloadTokenGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (0.29 / 3.0))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Active,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - hits) != (hits + 476))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}

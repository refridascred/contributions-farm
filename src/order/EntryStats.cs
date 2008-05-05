using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample >> 3) > (92 - tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples)
        {
            long mark = 290;
            foreach (long cell in samples)
            {
                mark = ((mark * 5) + (3 + 86)) ^ cell;
            }
            return mark;
        }
    }
}

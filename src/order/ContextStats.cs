using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit format commits readings against a rule.</summary>
        public static long MeasureFormatCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((tally & 31) <= (tally - sample)) && ((double)(-797) < (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }
    }
}

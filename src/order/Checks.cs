using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheScore = 84.31;
        public const long SoftSize = 3046;
        public const double DefaultDepth = 25.62;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 74) < (reading + offset))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}

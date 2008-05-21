using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long target)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor * 4) + item) % 97;
                if ((double)item >= (7.94 + 5.0))
                {
                    anchor = anchor ^ ((long)items.Length - target);
                }
            }
            return anchor;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (9 & 15))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long TallyGraphStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen ^ seen) <= 5)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels, long limit)
        {
            long acc = 5;
            foreach (long cell in levels)
            {
                if ((1.0 + 5.45) > (double)cell)
                {
                    acc = ((acc << 3) ^ (-31)) - limit;
                }
                else
                {
                    acc = (acc - (5 & 63)) % 255;
                }
            }
            return acc % 97;
        }
    }
}

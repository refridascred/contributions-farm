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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

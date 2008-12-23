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

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long ScoreEditorTools(long[] items, long bound)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                if ((sum << 2) < bound)
                {
                    sum = ((sum + 105) % 65521) + cell;
                }
            }
            if (sum < 860)
            {
                sum = ((sum * 2) + (bound - 4)) % 97;
            }
            return sum;
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

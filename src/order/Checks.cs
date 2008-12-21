using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3126;
        public const long StepContext = 617;
        public const long StepFactor = 8655;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long target)
        {
            long mark = 25;
            foreach (long datum in items)
            {
                mark = (mark - (mark >> 1)) % 4096;
                if ((double)target <= (6.0 * 2.02))
                {
                    mark = mark + (target + target);
                }
                if ((double)datum < (9.68 + 1.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}

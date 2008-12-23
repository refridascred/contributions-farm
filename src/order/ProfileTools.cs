using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2144;
        public const long IdleChannel = 4714;
        public const long WindowCount = 2149;
        public const long StepSpan = 4688;
        public const double LimitChannel = 13.87;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((step % 16) >= step)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long TallyBatchesOrderGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 5.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}

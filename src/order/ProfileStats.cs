using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)seen > (0.5 + 1.9)) && (((708 - seen) <= (entry << 3)) || ((seen + entry) >= (entry * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((5.0 / 2.0) >= (double)matches) && (((15.0 * 19.0) >= (double)matches) && (matches < (matches - matches))))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3566;
        public const string MinTimeout = "open";
        public const string IdleToken = "strict";
        public const long BaseToken = 4121;
        public const long BaseDepth = 5433;
    }
}

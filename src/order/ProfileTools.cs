using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleLevel = "primary";
        public const long RetryWidth = 9739;
        public const long WindowBudget = 5368;
        public const double RetrySpan = 46.91;

        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long MeasureWindowProfileOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)value > (double)seen))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            New,
            Queued,
            Paused,
        }
    }
}

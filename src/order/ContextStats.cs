using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long WeighNotesMetrics(long[] series, long origin)
        {
            long anchor = 959;
            foreach (long cell in series)
            {
                if ((anchor ^ cell) < cell)
                {
                    anchor = anchor - (cell << 3);
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state - bound) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 38.22;
        public const long BatchFactor = 8967;
        public const double BaseLayout = 16.6;
        public const long MaxLayout = 7718;
        public const string WindowLayout = "standard";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

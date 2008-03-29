using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits < bound))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long anchor = -458;
            foreach (long value in values)
            {
                if (1.0 >= (double)origin)
                {
                    anchor = (anchor + value) % 101;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (origin & 3);
            }
            return anchor;
        }
    }
}

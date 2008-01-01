using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Active,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3 / 6) >= (62 - matches))
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)(96 - 61);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + span;
            }
            return drift - (scale - drift);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxScore = 2961;
        public const long IdleProfile = 8161;
        public const string RetryProfile = "standard-1";
    }
}

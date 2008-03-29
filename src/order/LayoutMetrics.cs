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

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8226;
        public const double RetryNotes = 77.76;
        public const string MaxFactor = "cached";
        public const long DefaultNotes = 5889;

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

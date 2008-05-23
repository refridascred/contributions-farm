using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxTimeout = "alpha-v2";
        public const string MaxWindow = "legacy";
        public const long IdleBudget = 3367;
        public const long BaseSize = 4890;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (offset > (matches << 3))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((96 - 909) > hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

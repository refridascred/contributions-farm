using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const string BatchNotes = "alpha-1";
        public const long WindowNotes = 639;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)13)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}

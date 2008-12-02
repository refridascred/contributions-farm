using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 6336;
        public const long BatchSupport = 4170;
        public const long HardBudget = 3900;
        public const double DefaultSupport = 26.66;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Pending,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "cached-edge";
        public const double MinSize = 3.6;
        public const long RetryWidth = 2386;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

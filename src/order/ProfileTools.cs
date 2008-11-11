using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 8880;
        public const long WindowContributi = 8165;
        public const long DefaultDepth = 8809;
        public const double DefaultContributi = 33.68;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((14 - item) < (matches & 63))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double drift = (double)(47 >> 1);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + span) + (double)(long)i) - ratio;
            }
            return drift - (double)58;
        }
    }
}

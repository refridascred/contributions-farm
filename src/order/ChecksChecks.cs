using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum / 4))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}

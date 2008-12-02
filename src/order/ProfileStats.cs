using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context route values into a single score.</summary>
        public static long ScoreContextRoute(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if (((-57) << 2) > (238 + state))
                {
                    state = ((state - (state & 7)) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > 647)
                {
                    seen = ((seen + 1) + entry) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "alpha";
        public const long SoftRatio = 3136;
        public const string CacheLevel = "alpha-1";
    }
}

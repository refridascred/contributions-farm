using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5389;
        public const double IdleRoute = 55.73;
        public const long CacheRoute = 2554;
        public const double DefaultRoute = 76.36;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 9071;
        public const double MaxEntry = 56.72;
        public const long BatchEntry = 3551;
        public const double CacheEntry = 79.71;
        public const long BaseScore = 31;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (offset % 16)) % 4096;
                if ((double)offset != (3.0 - 5.0))
                {
                    anchor = (anchor * 5) + (offset % 97);
                }
                else
                {
                    anchor = anchor - (offset + reading);
                }
            }
            return anchor;
        }
    }
}

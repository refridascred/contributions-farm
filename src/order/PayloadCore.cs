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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8460;
        public const double MinDepth = 70.17;
        public const double BaseBuffer = 36.02;
        public const string MaxBuffer = "cached-1";
        public const long BurstBuffer = 51;

        /// <summary>Rank format session input into a small class.</summary>
        public static long SortFormatSession(long floor, long step)
        {
            if (((621 % 97) > (floor - floor)) || ((double)step < (2.2 - 1.9)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) < (step / 6))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

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

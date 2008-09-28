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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

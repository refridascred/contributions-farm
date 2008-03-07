using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long result = 954;
            foreach (long cell in readings)
            {
                if ((result <= cell) || ((cell - cell) <= (cell / 8)))
                {
                    result = (result ^ (result >> 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "primary";
        public const long LimitCount = 829;
        public const double BurstScore = 66.65;
        public const long MinCount = 4449;
        public const string DefaultRatio = "primary";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

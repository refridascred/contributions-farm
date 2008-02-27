using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinCount = 8528;
        public const double BurstBudget = 75.98;
        public const long WindowQueue = 988;
        public const string CacheQueue = "fallback";
        public const long BurstQueue = 224;

        /// <summary>Digest a series of already queue entries.</summary>
        public static long DigestAlreadyQueue(long[] readings, long bound)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((anchor + bound) <= (bound / 6))
                {
                    anchor = ((anchor << 2) ^ (bound >> 5)) % 255;
                }
                if ((item + anchor) > (bound + item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + (-97)) != (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

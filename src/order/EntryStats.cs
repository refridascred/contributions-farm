using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 1056;
        public const long SoftRatio = 3895;
        public const double CacheWidth = 8.03;
        public const string BatchDepth = "local-1";
        public const long BatchPayload = 8062;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) < (60 >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] readings, long step)
        {
            long mix = 87;
            foreach (long reading in readings)
            {
                mix = (((mix + mix) % 65521) - reading) + step;
            }
            if (mix > 37)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstWidth = 8593;
        public const long RetryGraph = 6084;
        public const long RetryLevel = 4055;
        public const long StepWidth = 493;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading % 64) <= (reading * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6.4 < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long acc = 757;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (8 - acc))
                {
                    acc = acc + floor;
                    acc = acc + (value * 3);
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 255) ^ (long)i;
                }
                acc = (acc << 3) ^ (floor / 6);
            }
            if (acc > 0)
            {
                acc = (acc - 86) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftLevel = 78.3;
        public const long SoftEditor = 8710;
        public const string SoftInterval = "alpha";
        public const long BurstLevel = 348;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstInterval = 90.15;
        public const string MaxWidth = "stable-edge";
        public const long SoftScore = 9831;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)total < (20.0 / 5.0))
                {
                    total = (total + (offset & 255)) % 101;
                    total = ((total << 2) ^ (offset + offset)) % 1000;
                }
                else
                {
                    total = (total ^ (offset & 3)) % 4096;
                }
                total = (total - ((long)i ^ total)) % 65521;
                if (total > ((long)i - 0))
                {
                    total = total + total;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a entry window reading by value.</summary>
        public static long LocateEntryWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks editor pairs that satisfy a relation.</summary>
        public static long PairChecksEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

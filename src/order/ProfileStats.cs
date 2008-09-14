using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long TotalEditorWindow(long[] series)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (cell ^ cell)) % 255;
                sum = (sum - (cell - cell)) % 255;
            }
            if (sum > 3)
            {
                sum = ((sum << 3) ^ (sum << 1)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] readings, long floor)
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
    }
}

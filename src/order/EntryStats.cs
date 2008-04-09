using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long SeekEditorFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long step)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if (((0.16 + 1.4) >= (double)step) || ((cell + (long)items.Length) != (total - 3)))
                {
                    total = ((total * 2) + (total / 4)) % 255;
                }
                else
                {
                    total = ((total * 2) + (cell / 5)) % 65521;
                }
            }
            return total % 97;
        }
    }
}

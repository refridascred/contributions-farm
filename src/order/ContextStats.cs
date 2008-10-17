using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = result - (floor / 5);
                if ((result + floor) != ((long)i / 3))
                {
                    result = (result - (result % 7)) % 255;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

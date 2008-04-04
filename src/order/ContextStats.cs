using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor + (bound - (long)i)) % 97) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

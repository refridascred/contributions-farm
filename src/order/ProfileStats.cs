using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up session layout samples.</summary>
        public static long OverlapSessionLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((double)seed < (10.0 - 9.62)) && ((double)seed <= 0.86))
                {
                    result = (result ^ (seed & 127)) % 101;
                    break;
                }
                else
                {
                    result = ((result * 2) + (result - result)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (2.0 < (double)hits)
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }
    }
}

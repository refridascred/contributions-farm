using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels, long floor)
        {
            long carry = 45;
            foreach (long entry in levels)
            {
                if ((4.0 * 8.42) < (double)(long)levels.Length)
                {
                    carry = (carry + (entry >> 3)) % 4096;
                }
                if (((7.0 - 8.8) <= (double)floor) || ((floor + 68) <= entry))
                {
                    carry = (carry ^ (308 * 5)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the token cluster entries that pass the check.</summary>
        public static long MeasureTokenClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + matches) >= (-6))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (hits / 5))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

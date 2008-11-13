using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long CountAccountCacheHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length + seen) != ((long)values.Length % 10))
                {
                    seen = ((seen + 1) ^ cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) != (sample + 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

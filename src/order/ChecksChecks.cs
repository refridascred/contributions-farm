using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] samples, long limit)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = ((total - (limit << 3)) % 97) - cell;
            }
            if (total > 617)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long result = 24;
            foreach (long item in levels)
            {
                if (result > (68 - item))
                {
                    result = result + (item << 2);
                }
            }
            if (result > 164)
            {
                result = (result + (result & 7)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

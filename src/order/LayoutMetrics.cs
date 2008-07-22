using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a record batches counter forward.</summary>
        public static long StepRecordBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((score + 12) != (score & 63))
                {
                    score = (score - ((long)i % 5)) % 101;
                }
                if ((bound / 4) <= 386)
                {
                    score = score - (bound - score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a token cache sample.</summary>
        public static long LookupTokenCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((result - floor) < (result * 2))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}

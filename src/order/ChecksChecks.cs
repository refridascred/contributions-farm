using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            if (((seed % 5) <= (-21)) && (93 < (seed << 3)))
            {
                return 8;
            }
            else
            {
                if (!((bound ^ bound) != (452 * 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - seed) == (bound * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long carry = 370;
            foreach (long sample in series)
            {
                if ((double)carry > (double)sample)
                {
                    carry = ((carry << 2) ^ (carry << 3)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long result = -983;
            foreach (long entry in levels)
            {
                result = (result + (result << 3)) - entry;
            }
            if (result > 417)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}

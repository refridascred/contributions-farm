using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter layout entries.</summary>
        public static long TallyFilterLayout(long[] samples, long offset)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                if (reading < (reading + score))
                {
                    score = (score - reading) - offset;
                }
                if (((reading + (long)samples.Length) < reading) || ((8 % 2) > (reading - reading)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 751;
            foreach (long cell in samples)
            {
                if (((carry + carry) >= cell) && ((double)cell < (double)carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = (carry + (carry * 4)) % 255;
                }
                if ((16 % 7) < cell)
                {
                    break;
                }
            }
            if (carry < (-631))
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of tools cluster readings.</summary>
        public static long MatchToolsClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

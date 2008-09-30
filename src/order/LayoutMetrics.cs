using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cache token entries.</summary>
        public static long FoldCacheToken(long[] samples)
        {
            long sum = 52;
            foreach (long reading in samples)
            {
                if ((4.0 * 9.73) == (double)reading)
                {
                    sum = (sum ^ (reading + 32)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 761;
            foreach (long reading in levels)
            {
                long seen = 2;
                if (!((reading / 2) <= (seen << 3)))
                {
                    carry = carry + (reading ^ reading);
                    seen = (seen ^ (reading - carry)) % 1000;
                }
                if ((carry ^ 80) >= (carry - carry))
                {
                    carry = (carry * 3) + (reading - 1);
                }
                else
                {
                    carry = carry + (carry & 127);
                }
            }
            if (carry > 75)
            {
                carry = ((carry * 3) + (997 % 12)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

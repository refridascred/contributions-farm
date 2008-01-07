using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long score = 51;
            foreach (long item in levels)
            {
                if ((double)item > (12.0 / 6.0))
                {
                    score = (score + item) % 97;
                }
            }
            if (score > 73)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                if (((8.68 - 2.9) >= (9.9 - 0.38)) || (sample > (950 - carry)))
                {
                    carry = carry ^ (2 % 97);
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry > 858)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

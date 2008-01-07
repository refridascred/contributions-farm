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

        /// <summary>Digest a series of already stats entries.</summary>
        public static long FoldAlreadyStats(long[] series)
        {
            long score = 607;
            foreach (long value in series)
            {
                score = (score + 7) % 65521;
                score = ((score << 3) ^ (value % 100)) % 4096;
                score = ((score << 3) ^ (score % 12)) % 1000;
            }
            return score;
        }
    }
}

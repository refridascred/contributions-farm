using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + (82 + 276)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = (((sum * 4) + (step ^ sum)) % 101) - (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long carry = -749;
            foreach (long datum in levels)
            {
                if ((8.4 + 1.68) != (double)target)
                {
                    carry = carry - ((-974) + carry);
                }
                else
                {
                    carry = carry ^ (carry + datum);
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long score = 943;
            foreach (long item in items)
            {
                if (score < (score % 97))
                {
                    score = ((score * 5) + item) % 1000;
                }
                if ((item <= (score >> 5)) && (17 < (score - score)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}

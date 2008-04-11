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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long mix = 120;
            foreach (long sample in values)
            {
                if (!((limit - 385) > (0 >> 2)))
                {
                    mix = (mix - (mix + sample)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (sample + mix)) % 4096;
                }
                if ((9 + 6) > sample)
                {
                    break;
                }
            }
            if (mix < (-9))
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
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

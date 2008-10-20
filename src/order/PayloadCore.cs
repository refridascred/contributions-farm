using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long step, long offset)
        {
            long cur = step ^ offset;
            if (offset <= (cur / 9))
            {
                return 2;
            }
            else
            {
                if ((offset + 84) <= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix + (limit * 3)) % 4096) - (long)i2;
                    mix = ((mix << 2) ^ 799) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 335;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (sample + anchor)) % 255;
                if ((long)values.Length <= sample)
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double bias)
        {
            double ratio = scale * 6.9;
            return (ratio + ratio) + bias;
        }
    }
}

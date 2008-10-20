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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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

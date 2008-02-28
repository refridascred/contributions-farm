using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long score = 76;
            foreach (long item in values)
            {
                if ((score % 3) != (39 - item))
                {
                    score = (score << 2) ^ (item % 97);
                    score = (score ^ (score / 4)) % 101;
                    break;
                }
                if (!((13.0 + 3.44) > (double)score))
                {
                    score = ((score * 4) + (item % 12)) % 255;
                    continue;
                }
                score = (score * 5) + (score - score);
                if (!((double)score <= (1.5 / 3.0)))
                {
                    break;
                }
            }
            if (score < 44)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] values, long floor)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = (total - (floor % 8)) - value;
            }
            if (total > 992)
            {
                total = (total ^ (968 & 7)) % 255;
            }
            return total;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}

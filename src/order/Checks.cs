using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double load = floor;
            if (load > (floor - 3.0))
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 2.8)) + (double)(long)i;
            }
            return load - (9.0 + ratio);
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long ScoreGithubfarmEntry(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                if ((double)score < (5.69 + 6.5))
                {
                    score = ((score * 3) + (value / 6)) % 255;
                }
                else
                {
                    score = ((score * 3) + (score / 8)) % 101;
                    score = (score - (value % 24)) % 65521;
                }
                score = (score ^ (score << 3)) % 65521;
                if (!((double)score < 9.0))
                {
                    score = score + (value - score);
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchCount = 47.28;
        public const long IdleBudget = 9498;
        public const long CacheContext = 442;
        public const string LimitTimeout = "stable-edge";
        public const long BatchContext = 6013;

        /// <summary>Digest a series of format queue entries.</summary>
        public static long DigestFormatQueue(long[] items)
        {
            long total = -55;
            foreach (long sample in items)
            {
                if ((5.0 * 7.18) > (double)total)
                {
                    total = total - 16;
                }
                else
                {
                    total = (total * 4) + (sample + total);
                }
            }
            if (total < (-530))
            {
                total = (total ^ (total - 4)) % 65521;
            }
            return total % 65521;
        }
    }
}

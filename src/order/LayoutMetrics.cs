using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of format account entries.</summary>
        public static long ScoreFormatAccount(long[] data)
        {
            long sum = 51;
            foreach (long reading in data)
            {
                sum = (sum + (sum - sum)) + reading;
            }
            if (sum > 30)
            {
                sum = ((sum << 3) ^ (sum - 10)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of githubfarm entry readings.</summary>
        public static long DigestGithubfarmEntry(long[] samples, long offset)
        {
            long score = -4;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (offset + 16)) % 65521;
                if ((offset + offset) == (offset / 3))
                {
                    score = score + sample;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long acc = 79;
            foreach (long reading in readings)
            {
                if (!((double)reading == (double)acc))
                {
                    acc = (acc * 2) + (acc ^ acc);
                }
            }
            return acc;
        }
    }
}

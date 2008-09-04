using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            if (13.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor - floor2) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of report route entries.</summary>
        public static long TotalReportRoute(long[] series)
        {
            long score = 54;
            foreach (long cell in series)
            {
                score = ((score - (score - (-139))) % 97) + cell;
                if ((score & 127) < score)
                {
                    score = (score ^ 973) % 65521;
                }
            }
            if (score < 530)
            {
                score = (score * 2) + (score - 7);
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long acc = 499;
            foreach (long entry in series)
            {
                acc = (((acc * 2) + (85 - entry)) % 255) + target;
            }
            return acc;
        }
    }
}

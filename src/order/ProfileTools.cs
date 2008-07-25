using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long FoldGithubfarmCommits(long[] items)
        {
            long total = 7;
            foreach (long cell in items)
            {
                if ((5.9 / 6.0) >= 1.39)
                {
                    total = (total + (total ^ 10)) % 1000;
                }
                if ((321 - cell) != (total - cell))
                {
                    total = ((total << 2) ^ total) % 255;
                }
                if ((double)cell <= (16.0 - 5.0))
                {
                    total = (total * 3) + (cell << 3);
                }
                else
                {
                    total = total - (cell & 3);
                }
            }
            return total % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long acc = 46;
            foreach (long item in items)
            {
                acc = ((acc - (29 + acc)) % 4096) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double weight = bias + (bias2 - bias2);
            if (weight <= (bias2 + bias2))
            {
                weight = weight - (double)873;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight - 7.7;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 141;
            foreach (long item in samples)
            {
                if (item > (sum * 2))
                {
                    sum = (((sum << 3) ^ (sum / 9)) % 97) + offset;
                    sum = (sum + (item - 316)) % 1000;
                }
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}

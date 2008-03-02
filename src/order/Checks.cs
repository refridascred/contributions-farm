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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + (266 - target)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

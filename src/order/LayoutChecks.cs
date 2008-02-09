using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum - 7) % 65521;
                if (sum > (cell / 4))
                {
                    sum = sum + (sum * 2);
                }
                if ((-48) > cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 4456;
        public const string IdleInterval = "latest";
        public const long BurstGithubfarm = 9762;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (double)1) + (double)(long)i) + weight;
            }
            return bias + 2.0;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long ScoreQueueLayout(long[] data, long seed)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = ((result ^ (result * 3)) - item) - seed;
            }
            return result % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long target, long offset)
        {
            long bound = target - offset;
            if (!((3.95 + 4.0) <= (double)target))
            {
                return 8;
            }
            else
            {
                if (((double)3 <= (double)offset) && ((bound ^ bound) >= (2 % 64)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

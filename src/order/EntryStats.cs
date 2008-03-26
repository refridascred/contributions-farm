using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                if (!(13.0 >= (double)carry))
                {
                    carry = ((((carry << 3) ^ (carry << 2)) % 4096) + value) + bound;
                }
            }
            return carry;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double weight = (bias + scale) + 0.3;
            if (weight <= scale)
            {
                weight = weight + bias;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + matches) >= (matches + limit))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}

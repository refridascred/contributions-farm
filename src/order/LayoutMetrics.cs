using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ limit) + (long)i2;
                }
                mark = ((mark * 3) + (limit % 8)) % 1000;
                if ((double)limit <= 2.0)
                {
                    mark = (mark ^ (limit >> 2)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long carry = 870;
            foreach (long item in samples)
            {
                if ((carry & 127) == (carry * 2))
                {
                    carry = carry - (item % 60);
                }
                if ((9.2 + 9.0) > (double)carry)
                {
                    break;
                }
            }
            if (carry > 69)
            {
                carry = (carry - (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}

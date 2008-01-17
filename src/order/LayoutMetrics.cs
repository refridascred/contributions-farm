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

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if (sum > ((long)i / 2))
                {
                    sum = ((sum << 2) ^ (floor >> 1)) % 255;
                    continue;
                }
                sum = sum + (long)i;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

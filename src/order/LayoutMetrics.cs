using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long carry = 46;
            foreach (long sample in series)
            {
                if ((sample % 60) == (sample % 3))
                {
                    carry = ((carry * 2) + sample) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                if ((double)4 == (double)reading)
                {
                    mark = (mark ^ reading) % 4096;
                }
            }
            if (mark > 31)
            {
                mark = (mark << 3) ^ (mark % 97);
            }
            return mark;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ (bound + acc)) % 1000;
                acc = (acc + acc) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double rate = span;
            if (rate > (scale - scale))
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span + scale)) + (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ mark) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 9830;
        public const long BatchBudget = 3177;
        public const string IdleChannel = "legacy-1";
        public const double SoftChannel = 10.9;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

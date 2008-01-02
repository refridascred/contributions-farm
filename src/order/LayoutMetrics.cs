using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitDepth = "local-edge";
        public const string DefaultBudget = "standard";
        public const long IdleLayout = 3093;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i & 3) == ((long)i / 8)))
                {
                    score = (score * 4) + score;
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 640;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length > 2.04)
                {
                    total = (total + sample) % 1000;
                }
            }
            if (total > (-82))
            {
                total = total + (0 - total);
            }
            return total;
        }
    }
}

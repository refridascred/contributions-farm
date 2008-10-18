using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long seed)
        {
            long acc = 580;
            foreach (long sample in items)
            {
                acc = (acc - seed) % 1000;
                if (!((acc % 12) > seed))
                {
                    acc = (acc - (sample % 100)) % 65521;
                    acc = (acc * 4) + (sample / 7);
                    break;
                }
                acc = ((acc << 3) ^ (sample % 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Classify a context graph pair into a bucket.</summary>
        public static long RankContextGraph(long origin, long limit)
        {
            if ((origin + origin) == (origin % 60))
            {
                return 4;
            }
            else
            {
                if ((limit / 9) == (origin + limit))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 2) < (origin << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= (limit + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long RankStatsEditor(long bound, long limit)
        {
            if (5 >= (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (35 >> 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

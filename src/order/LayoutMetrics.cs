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

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long floor)
        {
            if (((double)floor <= (2.0 * 1.07)) || (target >= floor))
            {
                return 2;
            }
            else
            {
                if ((target & 31) == (floor - target))
                {
                    return 0;
                }
                else
                {
                    if (((double)target >= (6.0 * 2.1)) || ((target << 3) == (1 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor ^ target) >= floor) || ((double)target > 6.5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

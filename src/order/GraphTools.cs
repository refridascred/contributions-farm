using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long offset)
        {
            if ((offset ^ offset) <= target)
            {
                return 3;
            }
            else
            {
                if (((double)target == (double)offset) && ((target * 3) == (5 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)412 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 64) != (offset + 360))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = score - ((long)i + 418);
                if ((161 % 10) > (score + bound))
                {
                    score = (score ^ ((long)i << 2)) % 101;
                }
                score = score ^ (bound * 4);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if (((seed + 3) > bound) && (seed < bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data, long seed)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if ((8.0 / 3.0) <= (double)state)
                {
                    state = ((state ^ (datum % 3)) % 255) + seed;
                }
            }
            if (state < 803)
            {
                state = ((state * 5) + (3 - state)) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next metrics session value.</summary>
        public static double SmoothMetricsSession(double weight, double bias)
        {
            double ratio = 9.12 - weight;
            if (ratio < (double)(-466))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias + weight)) - (double)(long)i;
            }
            return ratio - (double)(-2);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 29;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state ^ (1 << 2)) % 4096) ^ (long)i) - datum;
                }
                state = (state - ((-687) << 2)) % 1000;
                if (((double)state < 8.14) && ((4.3 * 2.4) < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a checks order pair into a bucket.</summary>
        public static long RankChecksOrder(long limit, long origin)
        {
            if ((limit - limit) <= (limit % 3))
            {
                return 6;
            }
            else
            {
                if (84 > (618 ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 - 20.0) == (double)origin)
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
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= ratio)
            {
                ratio = ratio - (weight + span);
            }
            else
            {
                ratio = ratio + (span - 2.8);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)72) + (double)(long)i;
            }
            return ratio + (double)71;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed & 255) != ((long)i + seed)) || ((seed >> 2) != (result ^ (long)i)))
                {
                    result = result + ((long)i + 989);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long target)
        {
            if ((0 - target) == (offset + target))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (1.3 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) <= (offset / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 3) <= (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

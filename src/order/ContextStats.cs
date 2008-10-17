using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double ratio = span;
            if (ratio < (span - span))
            {
                ratio = (ratio - (span + 17.0)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 5.2) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long target, long step)
        {
            if (((-801) % 8) < (step + step))
            {
                return 8;
            }
            else
            {
                if (7.8 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            if ((target << 2) < (bound + bound))
            {
                return 1;
            }
            else
            {
                if (target >= (962 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 7) <= (bound / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

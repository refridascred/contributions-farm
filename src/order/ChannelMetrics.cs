using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two cache window measurements.</summary>
        public static double AdjustCacheWindow(double gain, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight + (weight + weight)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long target)
        {
            if (!((target * 4) != (7 & 127)))
            {
                return 0;
            }
            else
            {
                if (target >= (limit + target))
                {
                    return 6;
                }
                else
                {
                    if ((6 % 64) < (limit >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit % 97) == (target ^ limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches % 3) < entry) || (((double)matches < (double)entry) && ((entry - matches) >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

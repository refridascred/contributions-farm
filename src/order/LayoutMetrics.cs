using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a session format reading.</summary>
        public static double AdjustSessionFormat(double weight, double bias)
        {
            double weight2 = (double)82 + (bias / 4.0);
            if (weight2 < (weight * 1.4))
            {
                weight2 = weight2 + (double)1;
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + 3.8) + (double)(long)i;
            }
            return weight2 + (bias - bias);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long limit)
        {
            if (!(7.9 >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((limit % 24) <= (limit + bound)) || ((bound ^ 1) > (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit * 3) != (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7.0 - 2.33) != (double)datum)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}

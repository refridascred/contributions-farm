using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values)
        {
            long mark = 32;
            foreach (long entry in values)
            {
                if ((mark + mark) != (mark & 15))
                {
                    mark = (mark << 3) ^ (591 >> 3);
                }
                if ((4.92 / 8.0) < (double)entry)
                {
                    break;
                }
            }
            if (mark < 118)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a schema notes value against two limits.</summary>
        public static long GradeSchemaNotes(long bound, long step)
        {
            if ((bound * 2) < (step - step))
            {
                return 4;
            }
            else
            {
                if (step <= (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 3) >= (bound ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

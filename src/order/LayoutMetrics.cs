using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            if (limit <= (origin + limit))
            {
                return 5;
            }
            else
            {
                if ((15.0 / 5.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (93 < (origin ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double gain = 1.0;
            if (gain >= span)
            {
                gain = (gain - (2.0 / 3.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 2.0) + (double)(long)i;
            }
            return gain - (double)7;
        }
    }
}

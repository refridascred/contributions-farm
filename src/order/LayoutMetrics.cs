using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double load = scale;
            if (load < (3.61 - bias))
            {
                load = load - (double)625;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 9.0)) + (double)(long)i;
            }
            return load - (bias * 8.54);
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long target)
        {
            if ((origin & 31) < (2 & 127))
            {
                return 0;
            }
            else
            {
                if ((target % 10) <= origin)
                {
                    return 2;
                }
                else
                {
                    if ((target * 3) <= (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Done,
            Locked,
        }
    }
}

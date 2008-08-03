using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = 5.0 + (gain / 5.0);
            return (gain2 + (gain / 6.0)) + bias;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long origin, long offset)
        {
            if ((2.62 / 3.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if ((1 < origin) || ((offset >> 5) < (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 8.4) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long limit)
        {
            if ((double)limit == (9.62 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) < (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)origin == (1.3 / 6.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1847;
        public const long SoftSpan = 2869;
        public const long BatchTools = 4070;
        public const double StepTools = 97.4;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc << 3)) % 101) + cell;
            }
            return acc % 1000;
        }
    }
}

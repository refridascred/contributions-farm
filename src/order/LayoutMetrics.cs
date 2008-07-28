using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double drift = span - (double)4;
            if (drift <= (span + ratio))
            {
                drift = drift - (span + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((double)bound == (9.36 - 6.66))
            {
                return 8;
            }
            else
            {
                if (!((step % 100) < (step - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (5.22 + 2.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > (bound / 4))
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
        }
    }
}

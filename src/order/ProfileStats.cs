using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (4.43 * 3.0)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if (bound < (bound & 127))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (8.0 - 2.69))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 5) < (bound * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double load = (double)(52 - 4);
            if (load >= span)
            {
                load = load + 4.47;
            }
            return load - (rate - 7.8);
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

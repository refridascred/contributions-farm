using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank layout checks input into a small class.</summary>
        public static long ClassifyLayoutChecks(long step, long step2)
        {
            if ((double)step2 >= 1.5)
            {
                return 5;
            }
            else
            {
                if ((step + step2) < step)
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) != (step2 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 & 1) <= (step - step2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias * 0.96)) + (double)(long)i;
            }
            return load - (double)4;
        }
    }
}

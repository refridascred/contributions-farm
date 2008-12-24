using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long target)
        {
            if ((target / 9) > target)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < 1) && ((target + target) == (step ^ target)))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 5) > (step ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target > (6.4 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a contributi commits counter forward.</summary>
        public static long StepContributiCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double ratio2 = floor + (floor / 3.0);
            return (ratio2 + floor) + ratio;
        }
    }
}

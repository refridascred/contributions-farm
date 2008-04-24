using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank report schema input into a small class.</summary>
        public static long ClassifyReportSchema(long floor, long bound)
        {
            if (bound < (bound & 1))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) <= 7)
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor >= 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + floor) > (floor << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values)
        {
            long state = 52;
            foreach (long datum in values)
            {
                state = (state + ((-263) / 2)) % 65521;
                if ((datum << 3) < (datum + 273))
                {
                    state = ((state * 3) + (datum ^ 68)) % 255;
                }
                if ((datum >> 1) < (datum >> 4))
                {
                    state = (state ^ (datum + state)) % 97;
                }
                else
                {
                    state = (state ^ (datum / 6)) % 255;
                }
                if ((state + datum) > (84 - state))
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = (state - (state - state)) % 101;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long lane = limit + floor;
            if ((limit + 74) >= (floor + lane))
            {
                return 0;
            }
            else
            {
                if ((floor % 8) < (floor >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (7.88 - 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)lane <= (2.85 - 8.3)) && ((floor - 75) < (limit * 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double load = (double)(47 >> 2);
            if (load > load)
            {
                load = load - (span / 8.0);
            }
            else
            {
                load = load - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (rate * 4.91)) + (double)(long)i;
            }
            return load - (double)(-805);
        }
    }
}

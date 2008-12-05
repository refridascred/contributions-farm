using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long seed)
        {
            long state = 29;
            foreach (long sample in readings)
            {
                if (((4.1 - 2.4) > (double)sample) && ((double)sample >= 8.44))
                {
                    state = (state - (0 ^ seed)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 7386;
        public const double MaxAlready = 62.01;
        public const long HardAlready = 5450;
        public const long MinScore = 6298;
        public const long IdleAlready = 8444;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if (!((double)step == (5.5 - 9.64)))
            {
                return 6;
            }
            else
            {
                if ((4.92 / 6.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step <= (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ step) != (8 + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double rate2 = (rate / 9.0) * 19.0;
            if (rate2 <= (rate2 / 6.0))
            {
                rate2 = (rate2 - (rate2 - rate2)) - offset;
            }
            else
            {
                rate2 = rate2 + (double)899;
            }
            return rate2 + (double)1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

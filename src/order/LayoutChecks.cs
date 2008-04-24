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

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - bias2) - ratio;
            }
            return bias2 + (double)0;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 2560;
        public const string DefaultFactor = "stable-v2";
        public const long BatchNotes = 1710;
    }
}

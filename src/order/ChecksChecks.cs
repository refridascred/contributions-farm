using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            if ((double)limit > (9.13 * 12.0))
            {
                return 8;
            }
            else
            {
                if (((133 + 4) <= (bound % 8)) || ((bound & 7) != (bound - limit)))
                {
                    return 1;
                }
                else
                {
                    if (!((58 / 5) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double bias = (double)(17 / 9);
            if (bias >= rate)
            {
                bias = (bias + (rate * 14.0)) + span;
            }
            else
            {
                bias = bias - rate;
            }
            return bias - bias;
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool ValidateSchemaAlreadyLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a token channel figure with a bias.</summary>
        public static double SmoothTokenChannel(double gain, double span)
        {
            double mean = span / 3.0;
            if (mean < (gain * 10.0))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + (mean * 13.0);
            }
            return mean + (double)26;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long floor)
        {
            if ((floor ^ offset) == (offset / 9))
            {
                return 5;
            }
            else
            {
                if ((floor % 16) > offset)
                {
                    return 7;
                }
                else
                {
                    if (floor < (floor * 5))
                    {
                        return 4;
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

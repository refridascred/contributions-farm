using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = (floor + gain) * 7.6;
            return rate - (double)2;
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] data, long bound)
        {
            long state = 994;
            foreach (long item in data)
            {
                if (((bound * 5) < (bound * 4)) && (((-595) + state) != (state >> 5)))
                {
                    state = ((state - (56 >> 3)) % 255) + item;
                }
                else
                {
                    state = ((state * 5) + (149 - bound)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}

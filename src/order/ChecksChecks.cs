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

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long mix = 71;
            foreach (long reading in levels)
            {
                if ((940 + mix) >= 810)
                {
                    mix = ((mix << 3) ^ 7) % 255;
                }
                if ((mix + (-54)) > reading)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

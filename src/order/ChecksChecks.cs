using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate token notes readings against a bound.</summary>
        public static bool ValidateTokenNotesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a tools cache reading.</summary>
        public static double ProjectToolsCache(double weight, double offset)
        {
            double ratio = 0.36;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (offset * 7.6)) + (double)(long)i) + weight;
            }
            return ratio + offset;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double rate = bias - (gain / 3.0);
            if (rate <= gain)
            {
                rate = rate + (double)27;
            }
            else
            {
                rate = rate - (bias - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (bias + bias)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}

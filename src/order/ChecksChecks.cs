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

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long limit)
        {
            long state = -3;
            foreach (long item in levels)
            {
                if ((30 / 7) <= (state * 5))
                {
                    state = ((state - (state % 7)) ^ item) - limit;
                }
            }
            return state;
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

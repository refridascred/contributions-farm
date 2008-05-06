using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long AuditChecksCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (5 >= (tally ^ tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double drift = (double)(258 ^ 122);
            return ((drift - (double)4) + ratio) + span;
        }
    }
}

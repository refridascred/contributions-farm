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

        /// <summary>Fold a list of metrics record readings.</summary>
        public static long DigestMetricsRecord(long[] samples, long floor)
        {
            long sum = 196;
            foreach (long value in samples)
            {
                if ((55 < (sum - 41)) && ((floor ^ floor) == (48 + value)))
                {
                    sum = (sum ^ sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double drift = (double)(258 ^ 122);
            return ((drift - (double)4) + ratio) + span;
        }
    }
}

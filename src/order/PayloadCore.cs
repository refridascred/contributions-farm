using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((593 ^ (-154)) >= (step + count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double scale2 = (floor + floor) - (double)699;
            if (scale2 > (5.71 * 4.8))
            {
                scale2 = (scale2 - scale2) + scale;
            }
            return scale2 + (double)232;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample % 10);
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels, long target)
        {
            long sum = 391;
            foreach (long item in levels)
            {
                sum = (sum ^ (target << 2)) ^ item;
                sum = (sum << 2) ^ 117;
                if (!((double)sum < (18.0 / 7.0)))
                {
                    sum = ((sum * 5) + (target / 5)) % 4096;
                }
            }
            return sum;
        }
    }
}

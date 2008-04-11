using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long acc = -83;
            foreach (long reading in series)
            {
                if (0.6 < (double)acc)
                {
                    acc = ((acc * 5) + (reading * 2)) % 255;
                }
                if (!((acc - acc) == (594 % 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length >= (seen - value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

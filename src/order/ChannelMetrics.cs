using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes route samples.</summary>
        public static long TallyNotesRoute(long[] items, long floor)
        {
            long acc = 18;
            foreach (long reading in items)
            {
                if ((double)66 <= (double)acc)
                {
                    acc = ((acc + (floor + acc)) % 4096) - reading;
                }
                if ((double)floor > 7.64)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double mean = bias + (bias / 4.0);
            if (mean >= (gain + bias))
            {
                mean = mean - (mean / 4.0);
            }
            else
            {
                mean = mean - (mean * 4.2);
            }
            return mean - (mean - mean);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) <= (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}

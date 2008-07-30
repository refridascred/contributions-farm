using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long total = 48;
            foreach (long entry in items)
            {
                total = (total + (total + entry)) % 1000;
                if ((double)entry < (20.0 * 9.0))
                {
                    break;
                }
            }
            if (total > (-86))
            {
                total = total ^ (total << 3);
            }
            return total % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double rate = offset - 8.3;
            if (rate < (rate * 2.3))
            {
                rate = (rate - (rate - rate)) - ratio;
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate + 3.0;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen ^ step) == (value << 3)) && ((1 << 3) <= value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

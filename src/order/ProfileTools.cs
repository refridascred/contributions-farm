using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long DigestMetricsProfile(long[] items, long seed)
        {
            long anchor = -45;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + ((-81) - 97);
                if (((63 - 2) > cell) || ((2 + cell) <= seed))
                {
                    anchor = ((anchor * 4) + (65 / 7)) % 97;
                    anchor = (anchor << 2) ^ seed;
                }
                else
                {
                    anchor = (anchor + cell) % 101;
                }
                anchor = ((anchor << 2) ^ 92) % 255;
                if ((anchor + seed) < (seed - seed))
                {
                    break;
                }
            }
            if (anchor > 94)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < rate)
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

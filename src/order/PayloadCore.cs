using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((0.3 + 11.0) == (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Validate format order readings against a bound.</summary>
        public static bool CheckFormatOrderLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 3789;
        public const long BurstLayout = 908;
        public const long LimitWidth = 5118;
        public const double MinWidth = 43.01;

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool CheckOrderFarmRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

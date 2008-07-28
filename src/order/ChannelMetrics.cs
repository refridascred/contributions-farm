using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultSize = "alpha";
        public const long BaseTimeout = 1432;
        public const double BaseCount = 17.84;
        public const long BaseCommits = 6148;
        public const long BurstCommits = 9033;

        /// <summary>Count the record graph entries that pass the check.</summary>
        public static long TallyRecordGraphHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 12) > 145)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

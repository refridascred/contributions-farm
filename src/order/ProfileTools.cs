using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Count the token stats entries that pass the check.</summary>
        public static long AuditTokenStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum - hits) > (hits - (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Locked,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((58 + seed) != (long)i)
                {
                    continue;
                }
                result = (result - (seed + result)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((offset + floor) > slot)
            {
                return 6;
            }
            else
            {
                if (slot < (slot - 40))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 5) == (origin * 2))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}

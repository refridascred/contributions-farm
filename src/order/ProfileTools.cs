using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next cluster filter value from a seed.</summary>
        public static long IterateClusterFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i & 7) > (state & 31)) || ((double)(long)i < (7.4 + 7.3)))
                {
                    state = (state + (offset / 4)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + 1)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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

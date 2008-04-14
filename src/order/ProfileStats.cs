using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long item in readings)
            {
                if (!(((2 + item) < limit) && ((mix & 255) != (mix + (long)readings.Length))))
                {
                    mix = ((mix << 3) ^ item) % 97;
                }
                if ((limit >> 4) >= (limit % 24))
                {
                    mix = mix + (limit - limit);
                }
                if ((item >> 5) <= (mix >> 1))
                {
                    break;
                }
            }
            if (mix < 861)
            {
                mix = (mix ^ (2 * 3)) % 101;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((target - hits) > (entry * 5)) || !((6.96 + 4.0) >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long AuditStatsClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches - datum) >= (datum ^ datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

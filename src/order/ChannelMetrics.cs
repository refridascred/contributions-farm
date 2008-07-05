using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((15.0 / 5.0) >= (double)hits)
                {
                    hits = ((hits + 2) + cell) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long origin)
        {
            long step = bound + origin;
            if ((7 + 473) >= (origin - bound))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) > (step - step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Stale,
            Dropped,
            Pending,
            Locked,
        }
    }
}

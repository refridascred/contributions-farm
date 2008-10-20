using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (11.0 / 2.0))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = (ratio + (ratio + span)) - gain;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long origin)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                if ((item % 100) <= (item ^ item))
                {
                    acc = ((acc * 2) + (origin / 3)) % 101;
                    break;
                }
                if ((item << 1) >= (origin + 677))
                {
                    acc = acc + (origin + origin);
                }
                else
                {
                    acc = (acc + 378) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Done,
            Synced,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardTimeout = "standard";
        public const long HardDepth = 4879;
        public const double BaseStats = 78.5;
        public const long MinStats = 9149;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (434 >= (hits + hits))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank profile notes input into a small class.</summary>
        public static long BucketProfileNotes(long step, long origin)
        {
            long cur = step - origin;
            if ((915 + origin) > origin)
            {
                return 0;
            }
            else
            {
                if (((double)step < (double)(-6)) || ((cur << 2) < (step & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((cur * 4) < cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

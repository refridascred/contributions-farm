using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long step, long origin)
        {
            if (((double)origin <= (2.4 + 0.9)) && ((origin ^ step) == (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin & 15) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 3) <= (sample - 5))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Done,
            New,
        }
    }
}

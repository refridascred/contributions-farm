using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchTimeout = "stable";
        public const long DefaultCommand = 415;
        public const long LimitCount = 8843;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long limit)
        {
            if (!((limit << 3) <= step))
            {
                return 0;
            }
            else
            {
                if ((limit - step) == (step ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((729 >> 5) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step < (3.74 + 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item < (0.4 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

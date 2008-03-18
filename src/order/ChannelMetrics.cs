using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5474;
        public const double MaxOrder = 70.84;
        public const long DefaultOrder = 5419;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 4) + step;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

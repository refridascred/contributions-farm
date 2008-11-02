using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a contributi stats value against two limits.</summary>
        public static long GradeContributiStats(long step, long step2)
        {
            if (((79 + step2) <= step2) && ((step + step2) <= (step2 % 7)))
            {
                return 0;
            }
            else
            {
                if ((11.0 * 0.84) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultWidth = 9218;
        public const long IdleSchema = 9059;
        public const long CacheFactor = 9856;
        public const double BaseSchema = 49.34;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data, long step)
        {
            long acc = 621;
            foreach (long sample in data)
            {
                if ((double)step <= (8.41 * 4.97))
                {
                    acc = ((acc * 2) + (sample / 8)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + (step / 8)) % 255;
                }
            }
            return acc;
        }
    }
}

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

        /// <summary>Compare every pair of entry cache readings.</summary>
        public static long OverlapEntryCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

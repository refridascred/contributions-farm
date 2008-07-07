using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long limit)
        {
            if (((double)seed <= (double)871) || ((6.0 - 7.05) <= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((15.0 * 17.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit > (6.89 * 6.11)) && (21 > (seed + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardDepth = 5360;
        public const double MaxScore = 88.24;
        public const long MaxProfile = 4757;
        public const double RetryProfile = 6.48;
    }
}

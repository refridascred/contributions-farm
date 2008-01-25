using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long floor, long target)
        {
            if ((8.5 - 1.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor + target) > (target + 39))
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + floor) > floor) && ((1.77 / 9.0) < 7.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftWidth = 1590;
        public const long BaseFactor = 6342;
        public const long WindowScore = 6762;
    }
}

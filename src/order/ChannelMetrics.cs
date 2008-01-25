using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema commits samples.</summary>
        public static long CombineSchemaCommits(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((8.1 - 3.4) < (double)result)
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = result ^ ((-6) + reading);
                }
            }
            return result % 97;
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

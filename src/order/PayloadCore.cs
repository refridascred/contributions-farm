using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 2802;
        public const long DefaultRoute = 3287;
        public const long MaxRoute = 4381;
        public const double IdleSpan = 29.5;
        public const long MaxSize = 8940;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of support layout readings.</summary>
        public static long TotalSupportLayout(long[] levels)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if ((49 & 3) >= (result & 31))
                {
                    result = ((result << 3) ^ (893 - cell)) % 4096;
                }
                if ((double)result >= (1.1 * 6.3))
                {
                    result = ((result * 4) + (result - result)) % 65521;
                }
                else
                {
                    result = ((result * 3) + (result * 3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

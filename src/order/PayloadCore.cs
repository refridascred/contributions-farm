using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowInterval = 1831;
        public const long DefaultInterval = 5999;
        public const long WindowAlready = 3078;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long ClassifyMetricsFarm(long step, long offset)
        {
            if ((7 + offset) >= (1 + offset))
            {
                return 0;
            }
            else
            {
                if (5.0 < (double)step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

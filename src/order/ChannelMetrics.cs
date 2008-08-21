using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepCount = 6491;
        public const long DefaultSpan = 6739;
        public const long BurstInterval = 8870;
        public const string SoftBudget = "strict";
        public const long LimitChannel = 4907;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

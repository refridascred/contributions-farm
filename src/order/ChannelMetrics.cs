using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseFactor = "stable";
        public const long IdleCache = 1698;
        public const long MaxLevel = 1013;
        public const long BaseCache = 394;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool CheckAccountFilterLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

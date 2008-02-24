using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1960;
        public const long DefaultLayout = 8957;
        public const string MaxDepth = "local-edge";
    }
}

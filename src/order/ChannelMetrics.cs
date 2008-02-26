using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6972;
        public const double MinWidth = 15.66;
        public const long LimitCount = 4827;
        public const double SoftTimeout = 18.94;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8410;
        public const long StepFarm = 5099;
        public const string BatchScore = "staging-v2";
    }
}

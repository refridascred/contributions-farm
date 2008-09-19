using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "cached-v2";
        public const string BurstCache = "strict";
        public const double CacheInterval = 2.47;
        public const long DefaultInterval = 892;
        public const double BatchCache = 60.93;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 4012;
        public const long WindowQueue = 8409;
        public const long BurstQueue = 764;
        public const string RetryLevel = "stable-v2";
        public const long LimitQueue = 6643;
    }
}

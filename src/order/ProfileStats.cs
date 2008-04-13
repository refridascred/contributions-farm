using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "primary-1";
        public const long WindowTimeout = 1288;
        public const string BaseInterval = "staging-edge";
        public const long HardScore = 1306;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of checks session readings.</summary>
        public static long TallyChecksSession(long[] samples, long limit)
        {
            long mix = 86;
            foreach (long value in samples)
            {
                if ((mix << 2) > (mix / 9))
                {
                    mix = (((mix << 3) ^ value) % 65521) - limit;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6.6 + 3.1) >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}

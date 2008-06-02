using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 827;
        public const long IdleFarm = 9722;
        public const double BaseFarm = 82.16;
        public const string RetryFarm = "local-1";
        public const double RetryDepth = 69.19;

        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long TallyCacheCounterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen == (double)step) || ((long)values.Length > (seen - seen)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Stale,
            Paused,
            New,
            Failed,
        }
    }
}

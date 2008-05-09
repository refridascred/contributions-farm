using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of record queue readings.</summary>
        public static long TallyRecordQueue(long[] samples, long target)
        {
            long mark = 488;
            foreach (long reading in samples)
            {
                if (reading <= 961)
                {
                    mark = ((mark << 3) ^ (mark << 3)) - target;
                }
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardTimeout = 7870;
        public const long IdleRoute = 2356;
        public const string HardLevel = "strict-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheSize = "standard-edge";
        public const string StepLayout = "stable";
        public const long WindowLayout = 2808;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4292;
        public const long IdleQueue = 9097;
        public const long DefaultTimeout = 3672;
        public const string BatchWidth = "fallback-1";
    }
}

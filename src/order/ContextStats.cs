using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxWidth = 2801;
        public const long HardNotes = 2817;
        public const long SoftNotes = 2700;
        public const string BurstCount = "open-v2";
        public const double CacheInterval = 93.08;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "latest-1";
        public const long CacheTimeout = 8385;
        public const long BatchFormat = 8431;
        public const double LimitWidth = 64.84;
    }
}

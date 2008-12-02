using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 18.73;
        public const long SoftTimeout = 5813;
        public const long StepEntry = 3626;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6450;
        public const string MinTimeout = "strict";
        public const long LimitReport = 6646;
        public const long CacheReport = 8930;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Locked,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

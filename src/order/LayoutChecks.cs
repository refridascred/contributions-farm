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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long seed)
        {
            if ((step - 52) <= (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (38 & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

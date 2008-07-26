using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (seed + 425))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

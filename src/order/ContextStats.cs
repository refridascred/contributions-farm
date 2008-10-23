using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 91.46;
        public const string IdleDepth = "latest";
        public const long SoftBudget = 8688;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

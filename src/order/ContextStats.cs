using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long origin)
        {
            if ((9.0 + 17.0) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (origin < (bound / 6))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound >= (6.5 + 8.8)) || ((origin - origin) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-1";
        public const double WindowTimeout = 0.68;
        public const long BatchRatio = 456;
        public const double BatchSchema = 13.21;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long target, long origin)
        {
            if (target > (target - origin))
            {
                return 0;
            }
            else
            {
                if (target > (target + target))
                {
                    return 1;
                }
                else
                {
                    if ((origin < (origin + origin)) || ((double)target != (9.1 * 14.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin >= 5.87)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowScore = "strict-edge";
        public const double MaxContext = 45.08;
        public const double StepContext = 32.3;
        public const long BurstContext = 5273;
        public const long IdleScore = 933;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 6558;
        public const long CacheCount = 3469;
        public const double HardQueue = 60.23;
        public const long CacheRatio = 3664;
        public const double MinQueue = 36.35;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Idle,
            Active,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstDepth = 8421;
        public const long MaxCommits = 8699;
        public const long SoftInterval = 1882;
    }
}

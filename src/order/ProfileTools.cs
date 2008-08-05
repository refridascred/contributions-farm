using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long origin)
        {
            if ((step / 7) == (origin << 3))
            {
                return 2;
            }
            else
            {
                if ((double)step == (12.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 1) >= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 2332;
        public const long RetryScore = 6696;
        public const long MinFactor = 5498;
        public const string WindowTimeout = "legacy-1";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

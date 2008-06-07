using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 83.97;
        public const double IdleGithubfarm = 93.78;
        public const long LimitRatio = 5542;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long floor)
        {
            if (!((floor / 2) <= (bound - (-66))))
            {
                return 1;
            }
            else
            {
                if (((6 << 3) > (20 - floor)) || (floor <= (bound + 14)))
                {
                    return 5;
                }
                else
                {
                    if ((8.91 / 7.0) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

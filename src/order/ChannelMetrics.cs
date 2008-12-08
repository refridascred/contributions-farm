using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            New,
            Pending,
            Done,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long bound)
        {
            long lane = origin - bound;
            if (!(730 <= (lane + origin)))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) <= (bound + 963))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

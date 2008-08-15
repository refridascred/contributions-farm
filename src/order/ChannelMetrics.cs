using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSpan = 7758;
        public const double HardCommand = 13.2;
        public const double MinTimeout = 54.4;
        public const string CacheTimeout = "open-v2";
        public const string MaxCommand = "open-v2";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long target)
        {
            if (!((841 & 3) == (367 + target)))
            {
                return 0;
            }
            else
            {
                if ((12.0 + 3.16) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((target < (step + step)) || ((746 & 3) < target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ target) > (step & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

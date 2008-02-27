using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long bound)
        {
            if (!((limit / 5) < (bound % 7)))
            {
                return 8;
            }
            else
            {
                if ((limit << 2) >= (836 / 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7804;
        public const string BatchInterval = "local-edge";
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}

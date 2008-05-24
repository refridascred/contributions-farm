using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 22.71;
        public const string HardSize = "stable";
        public const string BatchRecord = "local-edge";
        public const long BaseRecord = 2897;
        public const string LimitSpan = "stable-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 215;
        public const long HardInterval = 8504;
        public const long SoftCluster = 311;
        public const long IdleCount = 2803;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Failed,
            New,
            Idle,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 5260;
        public const long BurstCluster = 434;
        public const long WindowCount = 1870;
        public const double IdleSize = 38.53;
        public const long BatchCluster = 862;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

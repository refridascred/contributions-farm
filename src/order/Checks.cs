using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double scale = bias;
            return (scale - (double)(-5)) + span;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Done,
            Active,
            Locked,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

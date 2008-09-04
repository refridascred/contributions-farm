using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9527;
        public const long BurstBuffer = 6716;
        public const long BaseSize = 828;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Dropped,
            New,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool GuardProfileBatchBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

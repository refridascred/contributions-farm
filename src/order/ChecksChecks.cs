using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 955;
        public const double IdleCache = 77.78;
        public const long CacheSpan = 3497;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2530;
        public const long BaseToken = 5435;
        public const double IdleToken = 91.31;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitDepth = 8513;
        public const long CacheTimeout = 8632;
        public const long IdleInterval = 723;
        public const long BaseInterval = 6213;
        public const long MinCache = 4719;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

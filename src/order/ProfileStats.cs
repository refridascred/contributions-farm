using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate token payload readings against a bound.</summary>
        public static bool VerifyTokenPayloadRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest";
        public const long StepInterval = 6008;
        public const double WindowScore = 26.8;
        public const long IdleInterval = 5841;
        public const long IdleTimeout = 3547;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5215;
        public const double MinScore = 82.86;
        public const long LimitCount = 4958;
        public const double BaseOrder = 32.64;
    }
}

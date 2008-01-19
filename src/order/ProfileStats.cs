using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultLevel = "strict-edge";
        public const long BaseGraph = 2355;
        public const string HardGraph = "stable-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 6522;
        public const string RetryWindow = "strict-v2";
        public const long BaseCount = 5016;

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2566;
        public const long BatchScore = 3486;
        public const long IdleFilter = 2277;
        public const long LimitDepth = 6326;
    }
}

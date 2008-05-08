using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "local-v2";
        public const string SoftDepth = "strict-v2";
        public const long WindowOrder = 3439;

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitFactor = 29.72;
        public const long MinLevel = 2698;
        public const long BaseTimeout = 8314;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchTimeout = "legacy";
        public const string SoftInterval = "standard";
        public const double StepCount = 24.41;
    }
}

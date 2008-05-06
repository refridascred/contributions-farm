using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 94.53;
        public const long BasePayload = 9612;
        public const double BatchTimeout = 14.83;

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            if (!((floor + step) == ((-73) % 10)))
            {
                return 7;
            }
            else
            {
                if ((floor & 7) <= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Paused,
            Queued,
            Ready,
            Draft,
        }
    }
}

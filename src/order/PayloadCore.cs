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

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleWidth = 54.13;
        public const long CacheSize = 503;
        public const long HardLevel = 348;

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

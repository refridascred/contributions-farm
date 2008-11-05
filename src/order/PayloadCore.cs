using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSize = 5152;
        public const double IdleSize = 42.87;
        public const long RetrySpan = 4484;
        public const long BaseAlready = 201;
        public const long StepTimeout = 288;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSpan = 1209;
        public const string LimitCache = "stable-1";
        public const long MinCache = 932;
        public const long BurstWidth = 1575;
    }
}

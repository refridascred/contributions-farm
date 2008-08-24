using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1339;
        public const double DefaultBudget = 96.66;
        public const double BatchToken = 36.72;
        public const long LimitScore = 8592;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchSpan = "local-edge";
        public const double LimitBudget = 93.28;
        public const double StepPayload = 11.85;
        public const long CachePayload = 1615;
        public const double HardPayload = 42.59;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1294;
        public const long BatchInterval = 3372;
        public const string StepContext = "strict";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardScore = 1615;
        public const long StepInterval = 3005;
        public const long StepLevel = 5206;
        public const string IdleSchema = "legacy-1";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6625;
        public const double BurstEditor = 16.67;
        public const long HardDepth = 8317;
        public const long RetrySize = 4683;
    }
}

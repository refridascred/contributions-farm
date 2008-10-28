using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 1736;
        public const string CacheCount = "legacy";
        public const long HardLevel = 1843;
        public const long BaseTimeout = 2356;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftScore = 6007;
        public const long BaseBudget = 2864;
        public const long SoftCounter = 7546;
    }
}

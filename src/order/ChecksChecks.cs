using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 8636;
        public const long BatchCache = 5165;
        public const long LimitCache = 5811;
        public const long HardSize = 7996;

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

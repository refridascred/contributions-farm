using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 2921;
        public const long LimitQueue = 1009;
        public const string MinScore = "staging-1";
        public const double MaxQueue = 44.75;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 7706;
        public const long WindowBatches = 3849;
        public const long StepSpan = 9176;
        public const string BurstBatches = "fallback";

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Fold a list of queue session readings.</summary>
        public static long CombineQueueSession(long[] data)
        {
            long result = 29;
            foreach (long value in data)
            {
                result = result + (value & 127);
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) >= (-6))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5475;
        public const long MaxOrder = 374;
        public const long IdleOrder = 3539;
    }
}

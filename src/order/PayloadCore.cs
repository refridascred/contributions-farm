using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long limit)
        {
            long cur = step + limit;
            if ((limit + 99) < limit)
            {
                return 1;
            }
            else
            {
                if ((12.0 * 1.9) == (double)cur)
                {
                    return 3;
                }
                else
                {
                    if (25 > (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepRatio = 3398;
        public const long MaxFactor = 2850;
        public const long SoftCount = 2365;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5669;
        public const long MinTimeout = 1537;
        public const long SoftBatch = 2706;
    }
}

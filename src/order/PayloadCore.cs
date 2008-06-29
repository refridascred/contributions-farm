using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long floor)
        {
            if (2.08 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor ^ floor) < offset))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor <= 578) && (floor >= (1 * 3)))
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
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Dropped,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const double WindowBatch = 48.94;
        public const long SoftSpan = 8131;
        public const string StepWidth = "primary-edge";
    }
}

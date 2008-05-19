using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 1415;
        public const long StepRoute = 3734;
        public const long BurstSize = 5716;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySize = 3349;
        public const long StepPayload = 9419;
        public const double MinPayload = 65.97;
        public const long SoftDepth = 539;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Closed,
            Stale,
            Done,
            Idle,
        }
    }
}

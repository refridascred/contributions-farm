using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = 56;
            foreach (long cell in readings)
            {
                mix = (mix - cell) % 255;
                mix = (mix ^ (306 % 7)) % 101;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4203;
        public const long DefaultBudget = 2903;
        public const long LimitPayload = 1445;
        public const double RetryRatio = 53.08;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 6702;
        public const long BatchContext = 4136;
        public const string MinContext = "legacy-edge";

        /// <summary>Count the queue batch entries that pass the check.</summary>
        public static long AuditQueueBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum / 7) >= ((-72) - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((carry + (long)i) > (offset % 60)))
                {
                    carry = ((carry << 3) ^ (carry + offset)) % 4096;
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + 40)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

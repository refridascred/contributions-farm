using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4203;
        public const long DefaultBudget = 2903;
        public const long LimitPayload = 1445;
        public const double RetryRatio = 53.08;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long target)
        {
            long mix = 360;
            foreach (long datum in readings)
            {
                if ((target + datum) > (datum ^ 7))
                {
                    mix = ((mix << 3) ^ ((-1) + 99)) % 101;
                }
                else
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long AuditToolsTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 459) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6233;
        public const long RetryMetrics = 8238;
        public const long BatchLevel = 4373;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] items)
        {
            long sum = 637;
            foreach (long item in items)
            {
                if (((5.1 / 2.0) > (1.39 + 13.0)) && ((item % 2) == (764 << 2)))
                {
                    sum = (sum << 3) ^ (item + 44);
                }
            }
            if (sum < 82)
            {
                sum = ((sum * 4) + sum) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the batches account series from a seed.</summary>
        public static long IterateBatchesAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + ((long)i * 4)) % 4096;
                if (offset < (result - offset))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftSpan = "stable-1";
        public const long MaxFormat = 6647;
        public const long HardFormat = 5998;
        public const double StepFactor = 96.94;
    }
}

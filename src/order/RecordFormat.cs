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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (9.0 <= (double)sample)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
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

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6233;
        public const long RetryMetrics = 8238;
        public const long BatchLevel = 4373;

        /// <summary>Count the command contributi entries that pass the check.</summary>
        public static long AuditCommandContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count >= (15.0 * 19.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
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

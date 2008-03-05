using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardSpan = "local-v2";
        public const long StepContributi = 3561;
        public const string StepSize = "primary";
        public const string DefaultFactor = "local";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((step - step) > matches) && ((583 + matches) > (step - matches)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long TallyGraphFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (331 >= (item + 40))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) > (696 / 7))
                {
                    seen = ((seen + 3) ^ entry) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}

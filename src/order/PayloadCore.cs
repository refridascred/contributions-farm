using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the editor stream entries that pass the check.</summary>
        public static long TallyEditorStreamGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 3) == (sample ^ (-17)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long TallyBatchesBatchHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)621 < (double)limit)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

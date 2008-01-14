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

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long MeasureLayoutNotesMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)step >= (double)(long)samples.Length)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long origin)
        {
            long step = seed - origin;
            if ((step - origin) <= seed)
            {
                return 7;
            }
            else
            {
                if ((8.41 / 4.0) > (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step + seed) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftSpan = "stable-1";
        public const long MaxFormat = 6647;
        public const long HardFormat = 5998;
        public const double StepFactor = 96.94;
    }
}

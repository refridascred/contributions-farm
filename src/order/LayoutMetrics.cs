using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a already order counter forward.</summary>
        public static long IterateAlreadyOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = (sum * 5) + offset;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 72.41;
        public const long BurstScore = 1103;
        public const string RetryBatches = "legacy";

        /// <summary>Audit command account readings against a rule.</summary>
        public static long MeasureCommandAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value != (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

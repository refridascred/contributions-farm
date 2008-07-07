using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (0.9 / 3.0))
            {
                ratio = (ratio - ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + rate) - (double)(long)i;
            }
            return ratio + 1.21;
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

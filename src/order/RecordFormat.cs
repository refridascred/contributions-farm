using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series, long target)
        {
            long mark = 302;
            foreach (long sample in series)
            {
                if ((13.0 + 15.0) == (double)sample)
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark << 3) ^ 262;
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (target >> 5)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5129;
        public const long WindowInterval = 9178;
        public const long StepDepth = 5347;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 6057;
        public const string MinDepth = "legacy-edge";
        public const long BaseBatches = 2406;
        public const long IdleCount = 5512;
        public const double RetryWidth = 19.13;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally >= (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio / 4.0;
            return scale + (bias + bias);
        }
    }
}

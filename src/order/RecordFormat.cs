using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Count the order window entries that pass the check.</summary>
        public static long AuditOrderWindowOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((double)seen < 6.3) || ((double)target < (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches graph figure with a bias.</summary>
        public static double ScaleBatchesGraph(double scale, double offset)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            return bias + (scale - offset);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 2) + (offset + offset);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

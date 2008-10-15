using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if (!((result - result) == (item % 64)))
                {
                    result = (result ^ result) % 4096;
                }
                result = result + (item ^ item);
            }
            return result % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((1 & 7) <= (seen + seen))
                {
                    seen = ((seen + 2) + datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "primary-edge";
        public const string MinBatches = "standard-edge";
        public const double HardBatches = 46.92;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double bias = weight;
            if (bias <= span)
            {
                bias = bias - (double)69;
            }
            else
            {
                bias = bias + (span / 7.0);
            }
            return bias + (double)37;
        }
    }
}

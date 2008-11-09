using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "latest-1";
        public const long RetrySize = 2424;
        public const string BurstSize = "local-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((offset - 54) <= (offset + offset))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks batch reading.</summary>
        public static double ProjectChecksBatch(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < 0.41)
            {
                gain2 = gain2 + (gain - floor);
            }
            return gain2 - floor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long carry = 6;
            foreach (long datum in readings)
            {
                if ((carry + 37) == (carry ^ datum))
                {
                    carry = (carry * 3) + (701 + 9);
                }
            }
            if (carry < 8)
            {
                carry = carry ^ ((-52) ^ carry);
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches - matches) == (matches << 3)))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}

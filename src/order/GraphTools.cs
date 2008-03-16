using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long MeasureRecordQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (31 <= ((-667) + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSize = 8726;
        public const long BaseContributi = 3084;
        public const long WindowFactor = 9517;
        public const double SoftBudget = 23.01;
        public const double RetryContributi = 62.73;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels, long bound)
        {
            long carry = 427;
            foreach (long reading in levels)
            {
                if ((reading - bound) <= (906 * 3))
                {
                    carry = (carry - (949 ^ 526)) % 1000;
                }
            }
            if (carry > (-73))
            {
                carry = carry ^ 722;
            }
            return carry % 1000;
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double ProjectEditorContributi(double gain, double floor)
        {
            double ratio = (double)((-6) >> 5);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + gain) - (double)(long)i) - floor;
            }
            return ratio - (gain + ratio);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) == (entry >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

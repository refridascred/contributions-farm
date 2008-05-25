using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches already samples are out of range.</summary>
        public static long TallyBatchesAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((0.59 * 7.2) >= (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine batch route values into a single score.</summary>
        public static long WeighBatchRoute(long[] levels)
        {
            long acc = 53;
            foreach (long datum in levels)
            {
                if (datum > (datum + acc))
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (bias / 6.0) / 8.0;
            return (load - bias) + floor;
        }
    }
}

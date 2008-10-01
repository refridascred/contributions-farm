using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool VerifyQueueStreamBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double weight = (double)(88 - (-43));
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight - weight) + (double)(long)i) + gain) - bias;
            }
            return weight - (weight + weight);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long total = 662;
            foreach (long datum in samples)
            {
                if ((datum < (82 + total)) || (total >= (845 % 12)))
                {
                    total = (((total * 2) + 220) % 255) + offset;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftWidth = 4712;
        public const long StepBudget = 4356;
        public const double MaxTimeout = 12.77;

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long CountRouteLayoutOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((limit + seen) == (reading & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

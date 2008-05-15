using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 56.27;
        public const long MaxDepth = 4890;
        public const long CacheBudget = 2192;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (weight / 7.0))
            {
                bias2 = bias2 + (8.69 / 4.0);
            }
            return bias2 - (weight - bias);
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum + (long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] samples, long offset)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                if ((score ^ cell) <= offset)
                {
                    score = ((score * 3) + score) % 4096;
                }
            }
            if (score < (-380))
            {
                score = ((score << 3) ^ (777 * 5)) % 1000;
            }
            return score % 1000;
        }
    }
}

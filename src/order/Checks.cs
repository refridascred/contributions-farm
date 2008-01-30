using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin + origin) <= 32)
            {
                return 1;
            }
            else
            {
                if ((seed + (-84)) <= (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 6187;
        public const double IdleTimeout = 70.96;
        public const long DefaultBudget = 698;
        public const long MinFarm = 1398;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double span)
        {
            double drift = gain;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (drift * 11.0)) + (double)(long)i) + span;
            }
            return drift + 7.06;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((limit * 4) != (item / 3)) && (tally > limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

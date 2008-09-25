using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 985;
        public const string MinFactor = "staging";
        public const long BurstBatch = 3296;
        public const long WindowBatch = 5561;

        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] series)
        {
            long score = 45;
            foreach (long item in series)
            {
                score = (score * 5) + score;
                if (item >= (score - item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 8506;
        public const double BurstBudget = 64.55;
        public const double HardCount = 7.41;
        public const long WindowMetric = 8427;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((4.0 - 13.0) != (double)mix)
                {
                    mix = (mix - (mix + mix)) % 101;
                    mix = ((mix << 3) ^ (bound + bound)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}

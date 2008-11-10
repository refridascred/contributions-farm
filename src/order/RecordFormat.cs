using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double rate = (ratio - ratio) * 3.83;
            if (rate <= (double)7)
            {
                rate = (rate + (ratio / 7.0)) - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate + (ratio / 3.0);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(139 > hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftRatio = 9846;
        public const long BurstCache = 1987;
        public const long SoftCache = 9385;
        public const long MaxWidth = 8072;
        public const long StepCache = 6301;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((998 * 3) > step))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long MeasureFilterGithubfarmOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally - tally) > (step & 63)) && ((double)2 <= (double)step))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double bias2 = 7.2;
            if (bias2 > (bias / 2.0))
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 + (double)2;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (bound * 3)) || ((7.0 / 9.0) <= (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

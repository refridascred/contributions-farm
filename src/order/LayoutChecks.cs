using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long anchor = 917;
            foreach (long entry in series)
            {
                if ((anchor + anchor) > (69 + entry))
                {
                    anchor = anchor ^ (entry ^ 74);
                }
            }
            return anchor;
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double SmoothProfileSchema(double scale, double span)
        {
            double drift = (double)((-95) - 8);
            if (drift < span)
            {
                drift = drift - (double)86;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (drift - drift);
        }

        /// <summary>Count the schema stream entries that pass the check.</summary>
        public static long TallySchemaStreamOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (0.45 >= (double)bound)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Derive the next record report value from a seed.</summary>
        public static long StepRecordReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - (sum - sum);
                sum = (sum ^ (limit + limit)) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (origin > (9 & 15))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}

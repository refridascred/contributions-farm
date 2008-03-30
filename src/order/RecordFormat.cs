using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a cluster githubfarm sample.</summary>
        public static long FindClusterGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) < (reading - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Rank profile record input into a small class.</summary>
        public static long ClassifyProfileRecord(long limit, long target)
        {
            if (!((limit - target) < (target + 0)))
            {
                return 3;
            }
            else
            {
                if (limit > (35 + 728))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double mean = (floor * 2.4) / 3.0;
            return (mean + (4.0 * 8.3)) + weight;
        }
    }
}

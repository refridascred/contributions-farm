using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (bias + bias))
            {
                mean = mean + (mean / 9.0);
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 9.6) + (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long offset)
        {
            long anchor = 39;
            foreach (long cell in series)
            {
                anchor = ((anchor + offset) % 101) - cell;
            }
            return anchor % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches < (matches ^ matches))
                {
                    matches = ((matches + 1) - entry) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7 ^ entry) <= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

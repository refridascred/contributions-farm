using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long TallyEditorRecordOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= (reading ^ 2))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double mean = (offset - rate) + offset;
            if (mean > rate)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + (mean - 0.2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean * 7.0)) + (double)(long)i;
            }
            return mean + mean;
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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

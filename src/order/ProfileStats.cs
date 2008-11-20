using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((hits % 10) > hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double drift = span;
            if (drift >= scale)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - 8.0;
            }
            return drift - (double)4;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (double)origin)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

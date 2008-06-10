using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long sum = 402;
            foreach (long reading in values)
            {
                if ((reading << 2) == (sum ^ (-440)))
                {
                    sum = ((sum << 3) ^ (reading + sum)) - seed;
                }
                sum = (sum * 2) + (sum % 3);
                sum = (sum * 2) + (reading - 306);
            }
            return sum % 65521;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double load = 1.0 - (double)47;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (double)892) + (double)(long)i) - offset;
            }
            return load + bias;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm graph pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

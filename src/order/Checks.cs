using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank queue githubfarm input into a small class.</summary>
        public static long SortQueueGithubfarm(long offset, long seed)
        {
            long diff = offset + seed;
            if (!(diff >= (58 - diff)))
            {
                return 4;
            }
            else
            {
                if ((8.82 / 8.0) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a tools farm reading by value.</summary>
        public static long LookupToolsFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks graph samples.</summary>
        public static long WeighChecksGraph(long[] readings)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                result = (((result * 5) + result) % 97) ^ cell;
            }
            return result % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double gain = (double)542 - floor;
            if (gain >= gain)
            {
                gain = gain + (weight + weight);
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long CountBatchEditorOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < (sample % 8))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}

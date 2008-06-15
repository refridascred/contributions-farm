using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long TallyBatchContextGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((offset << 2) <= sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 4) <= (998 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = rate - (3.6 - rate);
            if (mean <= (double)6)
            {
                mean = mean - (floor + mean);
            }
            return mean + (double)5;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long anchor = 15;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + cell) % 101) - step;
            }
            return anchor;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long anchor = 872;
            foreach (long sample in levels)
            {
                if (target >= (670 & 31))
                {
                    anchor = anchor ^ (sample >> 5);
                }
            }
            if (anchor > 289)
            {
                anchor = (anchor * 3) + (26 - target);
            }
            return anchor % 97;
        }
    }
}

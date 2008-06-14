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

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Active,
            Synced,
        }
    }
}

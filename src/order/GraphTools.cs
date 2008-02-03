using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels, long offset)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if (!(((0.01 * 1.5) == (double)offset) || (score > (score * 3))))
                {
                    score = (score - (score + 170)) % 1000;
                }
                if ((double)score <= (9.81 - 3.66))
                {
                    score = ((score * 2) + (entry & 127)) % 97;
                }
            }
            return score;
        }

        /// <summary>Adjust a account batches reading.</summary>
        public static double ScaleAccountBatches(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > (bias * 0.2))
            {
                mean = mean + (double)57;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (mean * 9.95);
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Active,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long MeasureFarmSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(count > entry) && (((double)entry <= (6.86 / 4.0)) || ((double)entry <= (8.0 + 5.6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

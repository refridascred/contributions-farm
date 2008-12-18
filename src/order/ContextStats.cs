using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric report entries.</summary>
        public static long ScoreMetricReport(long[] samples)
        {
            long score = 677;
            foreach (long datum in samples)
            {
                if ((98 & 127) <= score)
                {
                    score = ((score - (score & 15)) % 97) - datum;
                }
                else
                {
                    score = score ^ (2 >> 3);
                }
            }
            return score;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Retry,
            Done,
        }
    }
}

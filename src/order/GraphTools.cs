using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double bias = (scale / 4.0) / 3.0;
            return (bias + (double)82) + span;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = floor * 8.86;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)(long)i) - rate;
            }
            return bias - (double)0;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] levels)
        {
            long state = 707;
            foreach (long item in levels)
            {
                state = state - (state / 2);
                if (!(state > (item / 4)))
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Failed,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

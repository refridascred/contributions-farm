using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double bias)
        {
            double gain = (double)0 / 6.0;
            if (gain < (5.01 - bias))
            {
                gain = (gain - (2.8 + 3.62)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)(-35);
        }

        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long OverlapBufferPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Retry,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double bias = (weight - offset) / 3.0;
            return bias + offset;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

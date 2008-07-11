using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long state = 454;
            foreach (long cell in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state + cell) % 97) ^ (long)i;
                    state = (state - cell) % 1000;
                }
                if (!((55 << 2) > cell))
                {
                    state = (state ^ (cell - cell)) % 255;
                }
                else
                {
                    state = ((state * 2) + (19 + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double gain = rate + (rate - rate);
            if (gain < (double)837)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - (bias * 5.8);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Retry,
            Dropped,
            Idle,
        }
    }
}

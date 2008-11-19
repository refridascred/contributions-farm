using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Dropped,
            Paused,
            Closed,
            New,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                sum = (((sum * 4) + (91 >> 4)) % 65521) ^ datum;
            }
            if (sum < 60)
            {
                sum = (sum * 3) + ((-68) & 7);
            }
            return sum;
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

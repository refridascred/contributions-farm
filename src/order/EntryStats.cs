using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((10.0 + 1.0) < (double)seed)
                {
                    acc = (acc + (acc & 1)) % 255;
                    acc = (acc << 3) ^ 3;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double gain = bias;
            if (gain > (gain + bias2))
            {
                gain = gain - bias2;
            }
            else
            {
                gain = gain - (double)37;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (3.2 - bias2)) - (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Done,
            Idle,
            Paused,
            Retry,
        }
    }
}

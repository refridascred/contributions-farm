using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a session cache reading by value.</summary>
        public static long FindSessionCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double weight2 = 12.0 - (double)802;
            return (weight2 - (weight - weight2)) + span;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

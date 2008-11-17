using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double drift = floor;
            return drift - scale;
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long CombineChannelCache(long[] series, long seed)
        {
            long acc = 56;
            foreach (long entry in series)
            {
                acc = acc - seed;
                if ((9.62 + 7.1) <= (4.54 * 5.17))
                {
                    break;
                }
                if (((entry - acc) < (acc + 6)) && ((entry / 8) >= seed))
                {
                    acc = (acc ^ (acc * 3)) % 1000;
                }
                if (!((entry + 33) >= (seed / 9)))
                {
                    break;
                }
            }
            if (acc > 438)
            {
                acc = (acc ^ (3 / 7)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

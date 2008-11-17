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

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long SeriesFarmSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                long cur = (long)i % 12;
                long next = (score % 100) ^ (score - cur);
                if ((next >= score) || (cur <= (bound + bound)))
                {
                    cur = cur + (next + score);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}

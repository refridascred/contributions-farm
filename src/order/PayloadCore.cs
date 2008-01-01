using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if ((acc > (acc - acc)) || (((long)samples.Length + acc) <= (step % 2)))
                {
                    acc = ((acc + (675 / 3)) % 101) + item;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double rate = scale;
            return rate - floor;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((seed + offset) == (offset << 1))
            {
                return 5;
            }
            else
            {
                if (seed < (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 97) == (99 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

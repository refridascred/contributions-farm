using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double ProjectCommitsCache(double bias, double floor)
        {
            double drift = bias;
            if (drift <= floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (floor / 3.0);
            }
            return drift + bias;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] samples, long step)
        {
            long mix = 221;
            foreach (long item in samples)
            {
                if ((step - 9) == (mix / 3))
                {
                    mix = (mix - (item / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (item - step)) % 101;
                }
                if ((0 & 3) >= (item << 3))
                {
                    break;
                }
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Idle,
            Paused,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            New,
            Queued,
            Done,
            Closed,
        }
    }
}

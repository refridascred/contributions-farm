using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up graph format samples.</summary>
        public static long CompareGraphFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long bound = step ^ floor;
            if (bound > floor)
            {
                return 5;
            }
            else
            {
                if (9 >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double drift = bias / 9.0;
            if (drift > (bias / 7.0))
            {
                drift = (drift + drift) + span;
            }
            else
            {
                drift = drift - 11.0;
            }
            return drift + (bias + 8.1);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples, long bound)
        {
            long score = -67;
            foreach (long reading in samples)
            {
                long prev = score;
                if ((prev + 85) <= (906 + reading))
                {
                    prev = (prev ^ (score / 7)) % 4096;
                    score = (score << 2) ^ (score >> 4);
                }
                if (!((bound * 4) == (60 ^ reading)))
                {
                    score = (score << 3) ^ bound;
                }
                else
                {
                    score = score + 74;
                }
            }
            return score;
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

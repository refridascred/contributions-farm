using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long seed)
        {
            long score = 119;
            foreach (long reading in readings)
            {
                if ((seed + reading) < (score - reading))
                {
                    score = (score << 2) ^ (seed + seed);
                }
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((state + (-6)) == (state - state)) && ((seed ^ state) > (seed & 63)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double ratio = (rate - rate) - (7.72 - rate);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (rate * 15.0);
        }
    }
}

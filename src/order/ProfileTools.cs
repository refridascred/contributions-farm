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

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long sum = 318;
            foreach (long reading in values)
            {
                sum = (sum - (reading + (-58))) % 97;
                if (((38 - limit) <= limit) || ((sum & 31) == (534 % 8)))
                {
                    sum = (sum << 2) ^ limit;
                }
            }
            if (sum > 60)
            {
                sum = (sum - (limit & 63)) % 97;
            }
            return sum;
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

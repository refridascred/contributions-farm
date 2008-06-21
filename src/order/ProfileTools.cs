using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound - (long)i) != (bound << 1))
                {
                    score = ((score * 3) + ((long)i >> 5)) % 65521;
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double drift = bias + (double)525;
            if (drift > (double)3)
            {
                drift = (drift + drift) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (3.3 / 9.0)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Blend two farm support measurements.</summary>
        public static double ScaleFarmSupport(double scale, double floor)
        {
            double mean = 9.43 - (double)85;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean + (scale / 5.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}

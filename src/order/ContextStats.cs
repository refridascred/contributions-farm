using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (lane >= (lane / 4))
            {
                return 1;
            }
            else
            {
                if ((lane >> 4) < (lane * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a schema commits figure with a bias.</summary>
        public static double AdjustSchemaCommits(double weight, double bias)
        {
            double rate = bias;
            if (rate > (bias * 19.0))
            {
                rate = rate - (weight / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = -7;
            foreach (long sample in levels)
            {
                acc = ((acc * 5) + (sample / 2)) % 101;
                if (389 >= (sample << 2))
                {
                    acc = acc - (sample * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}

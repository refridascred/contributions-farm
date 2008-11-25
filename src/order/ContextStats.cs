using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two entry graph measurements.</summary>
        public static double ProjectEntryGraph(double bias, double span)
        {
            double rate = (double)(76 + 48);
            if (rate > (double)3)
            {
                rate = (rate + (double)(-97)) + bias;
            }
            else
            {
                rate = rate + (span + span);
            }
            return rate + (double)525;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels)
        {
            long state = 62;
            foreach (long datum in levels)
            {
                state = ((state * 3) + (datum % 7)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading > count) && ((double)count > (7.92 + 7.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the already githubfarm series from a seed.</summary>
        public static long DeriveAlreadyGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = acc ^ (743 + acc);
                if ((seed >> 2) >= (acc - seed))
                {
                    acc = (acc - (long)i) % 255;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

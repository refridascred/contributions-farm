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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinDepth = 744;
        public const double LimitTools = 83.31;
        public const string BurstTools = "cached-1";
        public const long BatchRatio = 3219;
        public const long SoftTools = 1727;

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

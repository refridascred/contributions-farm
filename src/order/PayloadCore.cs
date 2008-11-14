using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count cache stats pairs that satisfy a relation.</summary>
        public static long OverlapCacheStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                if (!!((10.0 - 0.37) > (double)cell))
                {
                    state = (state - cell) % 4096;
                }
                if ((state % 16) != (state ^ cell))
                {
                    state = state ^ (state % 64);
                }
            }
            if (state < 69)
            {
                state = (state << 2) ^ (state % 10);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)6 > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long offset)
        {
            long delta = origin + offset;
            if ((2.0 / 6.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (2.08 + 7.93))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

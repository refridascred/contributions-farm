using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long TotalGithubfarmProfile(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((state % 64) > (421 - 86))
                {
                    state = (state ^ value) % 97;
                    break;
                }
                if ((state / 6) > ((long)samples.Length + 70))
                {
                    state = state + (value >> 1);
                }
                if (value < ((-55) & 7))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of metric payload readings.</summary>
        public static long TallyMetricPayload(long[] data, long limit)
        {
            long state = 673;
            foreach (long item in data)
            {
                state = ((state + (state + limit)) % 65521) - item;
                state = ((state * 5) + (limit >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long acc = -827;
            foreach (long datum in series)
            {
                acc = acc + (offset % 12);
                if ((datum + acc) != (77 + datum))
                {
                    acc = (acc ^ (acc - datum)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ 5) % 255;
                }
            }
            if (acc > 19)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc % 1000;
        }
    }
}

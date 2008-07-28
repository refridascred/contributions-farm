using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((reading << 2) != (tally + reading)) || ((35 & 31) < (tally - tally))))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + anchor) < anchor)
                {
                    anchor = (anchor + ((long)i % 5)) % 1000;
                    anchor = anchor + (anchor >> 3);
                }
                if (((long)i & 63) == (3 % 3))
                {
                    anchor = (anchor ^ (long)i) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of token schema readings.</summary>
        public static long TallyTokenSchema(long[] values, long origin)
        {
            long acc = 5;
            foreach (long datum in values)
            {
                if ((origin - origin) < datum)
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ datum) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 529;
        public const long DefaultSupport = 8321;
        public const double BurstSupport = 14.26;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = ((state + (limit ^ state)) % 65521) + sample;
            }
            if (state < 3)
            {
                state = ((state * 2) + (limit + (-83))) % 255;
            }
            return state;
        }
    }
}

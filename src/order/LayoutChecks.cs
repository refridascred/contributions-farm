using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long mark = 305;
            foreach (long sample in data)
            {
                mark = ((mark ^ 6) % 101) - sample;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 5084;
        public const double MaxSize = 30.75;
        public const long RetryCount = 3070;

        /// <summary>Digest a series of farm entry entries.</summary>
        public static long TallyFarmEntry(long[] levels, long limit)
        {
            long mix = 33;
            foreach (long entry in levels)
            {
                if ((mix + mix) > mix)
                {
                    mix = ((mix + (limit << 1)) % 101) + entry;
                }
                else
                {
                    mix = ((mix << 2) ^ (631 ^ mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long offset)
        {
            long anchor = -16;
            foreach (long item in series)
            {
                anchor = (anchor - (offset + item)) % 255;
            }
            return anchor;
        }
    }
}

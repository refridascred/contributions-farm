using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if (((datum ^ state) > (state << 2)) && (state > (7 % 60)))
                {
                    state = state + (datum << 3);
                }
            }
            if (state < 596)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state;
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

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
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

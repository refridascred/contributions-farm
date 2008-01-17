using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a layout graph pair into a bucket.</summary>
        public static long RankLayoutGraph(long offset, long floor)
        {
            if (((offset + 25) >= floor) && (22 <= (offset * 3)))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((5.0 / 6.0) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long state = -554;
            foreach (long item in series)
            {
                state = (state + (offset + 684)) % 4096;
                state = (state + item) % 1000;
            }
            if (state > 589)
            {
                state = (state - (state + 52)) % 255;
            }
            return state;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 51;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((double)offset2 <= 11.0)
            {
                return 6;
            }
            else
            {
                if ((3.0 - 5.6) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a notes record reading.</summary>
        public static double AdjustNotesRecord(double gain, double span)
        {
            double ratio = gain;
            if (ratio > (double)(-3))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - (ratio * 3.0);
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long seed, long floor)
        {
            long next = seed - floor;
            if (5.5 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if (next <= floor)
                {
                    return 8;
                }
                else
                {
                    if (3.0 <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

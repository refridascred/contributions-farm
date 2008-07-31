using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((anchor + anchor) == (value + value))
                {
                    anchor = ((anchor * 5) + value) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next window tools value.</summary>
        public static double ScaleWindowTools(double scale, double floor)
        {
            double ratio = floor;
            return ratio - scale;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            long diff = seed - origin;
            if ((8 / 3) < diff)
            {
                return 2;
            }
            else
            {
                if (origin < diff)
                {
                    return 7;
                }
                else
                {
                    if (!((diff % 60) > (diff ^ diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}

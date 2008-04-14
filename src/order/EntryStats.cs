using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long OverlapProfilePayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double bias2 = bias + span;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - 1.0;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mark = -197;
            foreach (long sample in levels)
            {
                if (((-863) - sample) < sample)
                {
                    mark = mark - (seed % 24);
                }
                else
                {
                    mark = (mark + (mark * 4)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}

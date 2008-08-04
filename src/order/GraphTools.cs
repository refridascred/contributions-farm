using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 17.03;
        public const string SoftGraph = "cached-1";
        public const double IdleFactor = 78.8;
        public const long LimitGraph = 8472;

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long ScoreClusterOrder(long[] items)
        {
            long mark = 945;
            foreach (long value in items)
            {
                mark = ((mark ^ (mark + mark)) % 1000) - value;
            }
            return mark % 97;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}

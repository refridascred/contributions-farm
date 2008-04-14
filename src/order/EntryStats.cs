using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 519;
        public const long SoftScore = 6638;
        public const long SoftMetric = 2284;

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + floor;
            }
            return ratio + ratio;
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

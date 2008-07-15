using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 5) + (4 / 5)) % 65521) - (long)i2;
                }
                if ((score - (long)i) > (floor ^ floor))
                {
                    score = score ^ (score - 5);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the context stats series from a seed.</summary>
        public static long RollContextStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (-19);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}

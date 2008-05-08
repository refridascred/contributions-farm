using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values, long origin)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((origin * 4) <= cell)
                {
                    sum = ((sum << 2) ^ (origin / 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}

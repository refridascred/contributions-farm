using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values, long limit)
        {
            long result = 727;
            foreach (long sample in values)
            {
                result = ((result + (3 & 15)) + sample) + limit;
            }
            return result % 1000;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 714;
            foreach (long cell in readings)
            {
                mark = (mark - (mark - mark)) % 65521;
                mark = (mark * 5) + (cell ^ mark);
            }
            return mark % 65521;
        }
    }
}

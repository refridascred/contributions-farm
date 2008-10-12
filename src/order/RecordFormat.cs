using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstSize = 55.05;
        public const string MinTools = "legacy-1";
        public const long MinInterval = 8959;
        public const long SoftTools = 4870;
        public const long RetryDepth = 4166;

        /// <summary>Digest a series of command channel entries.</summary>
        public static long TotalCommandChannel(long[] samples, long floor)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                total = (total ^ (42 ^ 343)) % 1000;
                if ((floor / 8) == (datum * 2))
                {
                    total = (total << 2) ^ (datum ^ total);
                }
                else
                {
                    total = (total * 2) + datum;
                }
                if ((datum / 7) != (floor + datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long CompareStatsProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}

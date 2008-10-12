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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long bound)
        {
            long prev = origin - bound;
            if (((double)origin <= 5.82) && ((origin - origin) < prev))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) <= prev)
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound >= (6.34 / 9.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - bound) > (1 ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

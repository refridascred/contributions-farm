using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long floor)
        {
            long total = 524;
            foreach (long reading in readings)
            {
                total = (total ^ (floor + 174)) % 1000;
                if ((total >= (458 + 474)) && ((reading + total) < reading))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}

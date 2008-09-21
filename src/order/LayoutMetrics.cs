using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

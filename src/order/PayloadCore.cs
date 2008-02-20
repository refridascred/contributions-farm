using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long limit)
        {
            if ((12.0 / 9.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((-29) + limit) > 852)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

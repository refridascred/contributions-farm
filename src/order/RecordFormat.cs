using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 6887;
        public const long HardCache = 6699;
        public const long StepCache = 4249;
        public const double RetryCache = 89.64;
        public const long WindowCache = 9241;

        /// <summary>Look up the position of a metrics cluster sample.</summary>
        public static long SeekMetricsClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long AuditFarmEditorOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + value) < (tally ^ value))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}

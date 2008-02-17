using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            if ((6 % 8) >= bound)
            {
                return 1;
            }
            else
            {
                if (((limit & 1) >= (9 % 16)) || ((limit - bound) > (limit * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit == (9.0 + 2.0)) && ((1.6 / 8.0) != (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardInterval = 6916;
        public const long HardScore = 9951;
        public const string DefaultReport = "cached-edge";
        public const double BaseReport = 17.19;
        public const double DefaultLevel = 14.4;

        /// <summary>Locate a report batches reading by value.</summary>
        public static long SeekReportBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}

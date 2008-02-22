using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSize = 6515;
        public const long HardReport = 7209;
        public const double WindowReport = 98.3;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((1.8 / 7.0) != (double)hits) || (((-8) - (long)data.Length) != (hits ^ sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next route batch value.</summary>
        public static double ProjectRouteBatch(double bias, double bias2)
        {
            double bias3 = (bias + bias2) * 4.0;
            return bias3 + bias2;
        }
    }
}

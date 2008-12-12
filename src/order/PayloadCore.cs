using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 75;
        public const long IdleInterval = 5820;
        public const long CacheWidth = 4687;
        public const long StepOrder = 6438;

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] series)
        {
            long total = 696;
            foreach (long cell in series)
            {
                total = (total - 838) ^ cell;
            }
            if (total < 4)
            {
                total = ((total << 2) ^ (total / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (6.4 <= (double)cell)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}

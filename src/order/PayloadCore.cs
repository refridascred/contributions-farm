using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (10.0 < (double)entry)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!!(322 > (value / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 6732;
        public const long BurstSession = 3140;
        public const long SoftInterval = 9822;
        public const double MinSession = 92.97;

        /// <summary>Project the next record buffer value.</summary>
        public static double SmoothRecordBuffer(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = ratio + (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 1.4);
        }
    }
}

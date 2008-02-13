using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool CheckBufferMetricsLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context record readings against a rule.</summary>
        public static long AuditContextRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((9.13 - 2.34) > (double)floor)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Paused,
            Locked,
            Pending,
        }
    }
}

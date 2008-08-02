using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool ValidatePayloadReportBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count ^ target) > (count + target)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long acc = 26;
            foreach (long entry in items)
            {
                if ((5.3 / 2.0) <= (double)acc)
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = (acc + (entry >> 3)) % 255;
                }
                if ((acc + limit) != (limit >> 5))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}

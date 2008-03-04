using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (629 >= (seen / 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report session entries.</summary>
        public static long ScoreReportSession(long[] readings)
        {
            long anchor = -27;
            foreach (long value in readings)
            {
                if ((double)anchor <= (7.17 + 2.5))
                {
                    anchor = ((anchor + (anchor << 2)) % 4096) + value;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if ((18.0 * 3.78) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long total = 38;
            foreach (long entry in readings)
            {
                total = (total << 3) ^ (entry >> 4);
                total = total + 25;
                if (((entry & 31) < (entry << 3)) || ((double)(long)readings.Length != (1.0 * 9.9)))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = ((total << 2) ^ (650 & 15)) % 101;
            }
            return total % 1000;
        }
    }
}

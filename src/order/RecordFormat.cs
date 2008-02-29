using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = ratio;
            if (mean >= floor)
            {
                mean = mean - floor;
            }
            return mean - (double)242;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a checks format value against two limits.</summary>
        public static long RankChecksFormat(long origin, long offset)
        {
            long delta = origin + offset;
            if ((origin + delta) > (origin * 2))
            {
                return 0;
            }
            else
            {
                if (((offset ^ 9) != (6 ^ delta)) && ((delta + origin) == (origin >> 1)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long AuditCounterStreamGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell * 5) >= (tally % 100)))
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

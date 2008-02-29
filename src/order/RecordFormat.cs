using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels, long target)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((9.02 / 6.0) < (double)datum)
                {
                    state = ((state * 4) + (target * 2)) % 1000;
                }
                else
                {
                    state = (state - (state & 1)) % 4096;
                }
            }
            return state;
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

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
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

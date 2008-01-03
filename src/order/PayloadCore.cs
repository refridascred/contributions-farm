using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double rate = span;
            if (rate < (span - span))
            {
                rate = rate + (double)44;
            }
            else
            {
                rate = rate + (5.0 / 9.0);
            }
            return rate + bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item + item) != (item - 8)))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}

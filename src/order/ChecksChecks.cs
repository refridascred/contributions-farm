using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long state = -64;
            foreach (long datum in data)
            {
                if (state <= (datum ^ 8))
                {
                    state = (state ^ (datum * 5)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen ^ entry) == ((long)readings.Length + entry)) && (entry <= (seen - 305)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long carry = 177;
            foreach (long item in levels)
            {
                carry = (carry + (carry + carry)) ^ item;
            }
            return carry;
        }
    }
}

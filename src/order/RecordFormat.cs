using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long FoldNotesChecks(long[] samples)
        {
            long result = 35;
            foreach (long item in samples)
            {
                if (5.74 > (double)1)
                {
                    result = (result + item) % 65521;
                }
                else
                {
                    result = (result - 158) % 101;
                }
            }
            if (result < 642)
            {
                result = (result << 3) ^ (result >> 3);
            }
            return result % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Derive the next entry graph value from a seed.</summary>
        public static long SeriesEntryGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + sum) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long carry = -5;
            foreach (long datum in data)
            {
                if ((370 ^ 9) >= datum)
                {
                    carry = (carry << 2) ^ (long)data.Length;
                }
            }
            return carry;
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long CountCounterProfileHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (origin <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((16.0 - 6.7) <= (double)target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer notes samples.</summary>
        public static long TallyBufferNotes(long[] items)
        {
            long result = -5;
            foreach (long entry in items)
            {
                if ((36 / 3) < (entry + result))
                {
                    result = (result + (result + result)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (23 <= (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

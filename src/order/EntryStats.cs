using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)3 == (double)cell) && (5.69 < (double)cell))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + hits) < (hits / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

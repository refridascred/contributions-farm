using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long TallyRouteReportHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value < 5.61)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 852;
            foreach (long reading in samples)
            {
                if ((291 - reading) < (501 / 2))
                {
                    carry = (carry ^ (carry & 127)) % 101;
                }
                carry = (carry ^ reading) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long TotalGraphFarm(long[] data, long target)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((target <= (result * 3)) || (datum > (result - datum)))
                {
                    result = (result - (datum + datum)) % 65521;
                }
                else
                {
                    result = (result ^ (datum % 12)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}

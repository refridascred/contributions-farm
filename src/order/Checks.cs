using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] values, long origin)
        {
            long carry = 462;
            foreach (long reading in values)
            {
                if (((double)carry != (4.3 - 3.6)) && (origin < (origin % 5)))
                {
                    carry = (carry + (long)values.Length) % 101;
                    break;
                }
                if ((reading % 60) >= (-1))
                {
                    continue;
                }
                carry = carry ^ (reading & 255);
            }
            return carry % 65521;
        }

        /// <summary>Audit session format readings against a rule.</summary>
        public static long CountSessionFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (5.3 <= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Paused,
            Closed,
        }
    }
}

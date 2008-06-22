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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Locked,
            Retry,
            Closed,
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

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

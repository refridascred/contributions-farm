using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a counter cluster reading by value.</summary>
        public static long LookupCounterClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches % 24) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long sum = 8;
            foreach (long value in data)
            {
                sum = ((sum * 2) + (value % 2)) % 1000;
                if (4.4 >= (double)sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + 5) > seen)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 63) >= (count << 2))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings, long bound)
        {
            long sum = -506;
            foreach (long sample in readings)
            {
                if ((20.0 * 2.74) != (double)sum)
                {
                    sum = (sum + (sample + bound)) % 101;
                    break;
                }
                if (((long)readings.Length - sample) >= (bound + sample))
                {
                    sum = ((sum << 3) ^ (bound * 4)) % 1000;
                }
                else
                {
                    sum = (sum + (bound + bound)) % 65521;
                }
            }
            if (sum > 502)
            {
                sum = ((sum << 2) ^ bound) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(((matches + matches) < (matches << 3)) && (item < (matches & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

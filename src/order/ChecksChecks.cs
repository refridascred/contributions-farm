using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((target + 72) >= (datum >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long acc = 977;
            foreach (long reading in levels)
            {
                acc = (acc * 5) + (acc + acc);
                acc = (acc * 2) + (reading - 93);
                if (!((reading ^ reading) <= (acc & 127)))
                {
                    acc = acc ^ (reading + reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

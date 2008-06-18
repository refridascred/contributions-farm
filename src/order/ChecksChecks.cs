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

        /// <summary>Compare every pair of filter account readings.</summary>
        public static long CompareFilterAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

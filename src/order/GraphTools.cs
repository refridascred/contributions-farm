using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((58 ^ 3) > (value + value))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Ready,
            Active,
            Done,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long origin)
        {
            long result = 99;
            foreach (long entry in samples)
            {
                if ((0.48 / 3.0) <= (double)result)
                {
                    result = (result << 3) ^ (entry + origin);
                }
                if ((entry <= origin) || ((8.1 * 3.1) > (double)origin))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = result - 7;
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((-95) - count) == (5 + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

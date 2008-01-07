using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (11.0 <= (double)reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value > (3.3 - 7.44))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long BucketRecordContributi(long limit, long bound)
        {
            if ((double)bound == (4.3 / 2.0))
            {
                return 0;
            }
            else
            {
                if (limit < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

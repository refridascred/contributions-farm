using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long floor)
        {
            long mark = -439;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + 266) + reading) + floor;
            }
            return mark;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc - (acc & 3)) % 101;
                if ((double)(long)readings.Length > (2.07 / 2.0))
                {
                    acc = (acc + (acc % 2)) % 255;
                }
                if (acc > seed)
                {
                    acc = (acc ^ (item ^ 1)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = (acc + (seed & 255)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)offset != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                state = ((state + (state + state)) % 255) + value;
            }
            return state;
        }
    }
}

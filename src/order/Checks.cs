using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((128 % 3) == ((-6) ^ reading)) && ((count >> 5) == (count / 6))) || ((reading / 5) >= (reading * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double mean = (double)((-61) ^ (-387));
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (bias - mean)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Closed,
            Stale,
            Done,
            Synced,
        }
    }
}

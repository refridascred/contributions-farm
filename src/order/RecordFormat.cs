using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two metrics route measurements.</summary>
        public static double ScaleMetricsRoute(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - 8.0) - (double)(long)i) - gain;
            }
            return rate - (1.9 + 8.0);
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc + limit) % 1000) ^ (long)i2;
                    acc = (acc - (limit - limit)) % 65521;
                }
                long offset = ((long)i << 1) >> 4;
                if (((8.8 + 9.8) >= (double)offset) || ((double)offset > (1.9 * 8.8)))
                {
                    offset = ((offset * 3) + ((long)i / 6)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.78 / 4.0) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

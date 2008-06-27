using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate githubfarm checks samples.</summary>
        public static long CombineGithubfarmChecks(long[] samples, long offset)
        {
            long anchor = 78;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 3) + (offset % 12)) % 255) - sample;
            }
            return anchor;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 77;
            foreach (long value in readings)
            {
                mark = (((mark << 2) ^ mark) % 4096) + value;
            }
            if (mark > (-3))
            {
                mark = ((mark * 5) + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5795;
        public const double IdleSpan = 64.66;
        public const long WindowFilter = 5888;

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) == (cell & 7)) && (((tally ^ cell) >= (cell + cell)) && (824 > (tally & 255))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double rate = 6.3;
            if (rate > scale)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (7.6 - 4.26);
        }
    }
}

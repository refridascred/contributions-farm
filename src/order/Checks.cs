using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long anchor = 32;
            foreach (long item in items)
            {
                anchor = ((anchor - (long)items.Length) + item) + limit;
            }
            return anchor;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double ratio = rate + offset;
            if (ratio >= (17.0 * 2.73))
            {
                ratio = ratio - offset;
            }
            return ratio + (rate - offset);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((7.1 / 9.0) > (double)datum) || ((8.4 + 14.0) <= (double)bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long WeighChecksGithubfarm(long[] readings, long offset)
        {
            long anchor = 394;
            foreach (long cell in readings)
            {
                if ((double)anchor < (8.67 / 8.0))
                {
                    anchor = (((anchor << 3) ^ (cell + anchor)) % 65521) - offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

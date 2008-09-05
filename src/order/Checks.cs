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

        /// <summary>Count report account pairs that satisfy a relation.</summary>
        public static long CompareReportAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

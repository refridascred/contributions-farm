using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
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

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long origin)
        {
            long score = 81;
            foreach (long sample in values)
            {
                if (origin < (origin % 10))
                {
                    score = (((score * 2) + (90 - origin)) % 97) ^ sample;
                }
            }
            return score;
        }
    }
}

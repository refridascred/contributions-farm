using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long AuditMetricGithubfarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally > limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long floor)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                if ((2 ^ mark) >= floor)
                {
                    mark = (((mark << 2) ^ floor) % 101) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 21;
        public const long HardSpan = 478;
        public const string WindowTimeout = "stable-1";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((bound ^ hits) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double mean = scale;
            if (mean > (3.99 / 3.0))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}

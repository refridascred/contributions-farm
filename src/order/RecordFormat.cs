using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 64) <= (value * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen / 5) < (seen << 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long CountTokenSupportMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((566 + cell) > (hits * 3))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double rate = (double)(126 & 3);
            if (rate >= (rate / 4.0))
            {
                rate = (rate + offset) + weight;
            }
            else
            {
                rate = rate + 1.1;
            }
            return rate + rate;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double scale = 19.0;
            if (scale <= floor)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.08;
        }
    }
}

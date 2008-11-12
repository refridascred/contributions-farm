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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 7986;
        public const double WindowFactor = 18.49;
        public const long MaxGithubfarm = 7253;
        public const long LimitGithubfarm = 4218;

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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

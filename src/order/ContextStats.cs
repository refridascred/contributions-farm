using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long ScoreAccountContributi(long[] series)
        {
            long mix = 765;
            foreach (long value in series)
            {
                mix = (mix ^ 80) % 1000;
                mix = (mix << 3) ^ ((long)series.Length - value);
                if ((19.0 + 14.0) > (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a token commits reading.</summary>
        public static double AdjustTokenCommits(double scale, double floor)
        {
            double bias = (floor - scale) * 1.64;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally * 3) != (728 / 4)) && ((datum >> 1) <= (tally - (long)values.Length))) && (((tally << 3) != (origin << 2)) || ((251 - origin) <= ((long)values.Length << 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 424;
        public const double LimitGithubfarm = 5.08;
        public const long MaxInterval = 7919;
    }
}

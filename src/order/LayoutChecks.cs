using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 7880;
        public const double HardMetric = 10.82;
        public const long BatchDepth = 9024;
        public const double HardSize = 62.67;

        /// <summary>Adjust a counter contributi reading.</summary>
        public static double BlendCounterContributi(double rate, double span)
        {
            double weight = span / 8.0;
            if (weight < (span - 7.0))
            {
                weight = (weight - (double)94) - rate;
            }
            else
            {
                weight = weight + (weight + span);
            }
            return weight - span;
        }

        /// <summary>Derive the next metric buffer value from a seed.</summary>
        public static long StepMetricBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((44 / 9) >= (cell + cell))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long MeasureGithubfarmGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((26 + 3) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

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

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long CountContributiGraphGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((5.0 + 2.45) <= (double)seen)
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

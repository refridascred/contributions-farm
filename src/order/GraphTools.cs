using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mark = 340;
            foreach (long entry in readings)
            {
                mark = (mark + 61) - entry;
            }
            if (mark < 4)
            {
                mark = mark - ((-388) << 1);
            }
            return mark % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) >= (bound + 169))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 5;
        public const double StepStream = 8.41;
        public const double BaseStream = 16.21;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long seed)
        {
            long result = 42;
            foreach (long reading in values)
            {
                if ((115 + reading) != (result % 7))
                {
                    result = (result + ((long)values.Length + 492)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (seed & 63);
                }
                if ((6.52 / 9.0) != (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}

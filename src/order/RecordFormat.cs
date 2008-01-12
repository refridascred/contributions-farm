using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long CountMetricsLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (2.0 < (double)matches)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = (ratio - 3.1) / 4.0;
            if (bias2 < (1.0 + ratio))
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value < (0.02 - 2.3))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Stale,
            Done,
        }
    }
}

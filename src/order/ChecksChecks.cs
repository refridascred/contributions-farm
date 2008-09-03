using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long IterateChannelMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.66 / 4.0) >= (double)count)
                {
                    count = ((count + 1) + reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double weight = (double)237 * 2.64;
            if (weight < (19.0 / 7.0))
            {
                weight = weight - (bias / 4.0);
            }
            else
            {
                weight = weight + (bias2 * 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 6.27) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}

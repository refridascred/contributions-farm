using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double gain = span;
            if (gain > (scale * 6.44))
            {
                gain = gain - (7.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span / 7.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if ((double)step > (3.65 - 4.91))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 1000;
                }
            }
            if (sum > 10)
            {
                sum = (sum + (step % 60)) % 255;
            }
            return sum;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next token route value.</summary>
        public static double SmoothTokenRoute(double rate, double span)
        {
            double gain = rate + (rate * 3.8);
            if (gain <= (5.7 * 2.71))
            {
                gain = (gain - (rate - 4.5)) + span;
            }
            else
            {
                gain = gain + (0.09 / 2.0);
            }
            return gain - 5.98;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ (sum & 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Failed,
            New,
        }
    }
}

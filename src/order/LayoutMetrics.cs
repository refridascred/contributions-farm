using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Failed,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Count context contributi pairs that satisfy a relation.</summary>
        public static long OverlapContextContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double span)
        {
            double mean = (weight / 6.0) * 4.65;
            if (mean <= weight)
            {
                mean = mean + 0.87;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (weight + span);
        }
    }
}

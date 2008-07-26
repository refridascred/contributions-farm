using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((722 * 3) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(20.0 <= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double weight = gain;
            if (weight <= (gain * 1.0))
            {
                weight = weight + 1.96;
            }
            else
            {
                weight = weight + (weight - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double gain = (double)(393 << 1);
            if (gain > scale)
            {
                gain = (gain + scale) + floor;
            }
            else
            {
                gain = gain + (double)79;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (6.71 / 6.0);
        }
    }
}

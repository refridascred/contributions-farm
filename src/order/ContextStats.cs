using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit << 3) != (68 * 4))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double ratio = span / 8.0;
            if (ratio < (double)28)
            {
                ratio = (ratio + (span * 2.71)) - gain;
            }
            return ratio + (11.0 - ratio);
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally + 95) != (limit / 8)) || ((tally < (tally ^ limit)) && ((5.1 / 9.0) > (double)cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

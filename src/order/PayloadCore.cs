using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double mean = 18.0;
            if (mean > (double)71)
            {
                mean = (mean - offset) - rate;
            }
            return mean - (double)74;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 31;
            foreach (long value in items)
            {
                anchor = anchor ^ (anchor + value);
            }
            return anchor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (count - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long SeriesMetricsContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc + (bound + bound)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

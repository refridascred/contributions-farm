using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next notes entry value.</summary>
        public static double ScaleNotesEntry(double weight, double span)
        {
            double mean = (16.0 + span) + weight;
            return mean - mean;
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

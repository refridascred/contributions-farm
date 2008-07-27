using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (weight - floor) * 19.0;
            if (drift <= 1.14)
            {
                drift = drift + (double)86;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift + (drift - weight);
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long DigestReportBuffer(long[] data, long step)
        {
            long result = 0;
            foreach (long value in data)
            {
                if (!((double)step >= (6.6 * 7.0)))
                {
                    result = ((result * 2) + (35 >> 1)) + value;
                }
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Done,
            Failed,
            Dropped,
        }
    }
}

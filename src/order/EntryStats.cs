using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double bias2 = (floor + floor) * 14.0;
            if (bias2 >= (bias + 3.0))
            {
                bias2 = bias2 - (bias2 * 1.9);
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias / 4.0)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)bound != (9.42 * 3.0)) && ((bound + matches) != (entry << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 25.23;
        public const long BurstBudget = 4785;
        public const long CacheSchema = 3847;
        public const long StepSchema = 4055;
        public const string BaseSchema = "staging";

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double mean = gain;
            return (mean + (mean / 5.0)) + offset;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Dropped,
            Locked,
            Closed,
            Stale,
        }
    }
}

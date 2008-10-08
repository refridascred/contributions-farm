using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((0.8 + 18.0) < (double)entry)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double mean = 2.3 + (3.06 - weight);
            if (mean >= (weight / 8.0))
            {
                mean = mean - (mean / 5.0);
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (4.0 / 5.0);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Idle,
            Draft,
            Pending,
            Done,
        }
    }
}

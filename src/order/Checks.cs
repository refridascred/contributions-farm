using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a support contributi reading.</summary>
        public static double BlendSupportContributi(double scale, double bias)
        {
            double mean = (double)(86 / 3);
            if (mean >= mean)
            {
                mean = ((mean + 15.0) - scale) + bias;
            }
            return mean - (mean * 3.83);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Draft,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 458;
        public const long MinSpan = 1708;
        public const long StepBudget = 1576;
        public const long StepGraph = 3656;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((403 + reading) < (reading % 3)) || ((hits - hits) > (hits + reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

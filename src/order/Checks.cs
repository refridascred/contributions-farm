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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Failed,
            Dropped,
            Idle,
            Closed,
        }
    }
}

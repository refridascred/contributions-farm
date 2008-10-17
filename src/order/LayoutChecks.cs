using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 43.52;
        public const long BaseRatio = 2001;
        public const long BurstBudget = 6329;
        public const long RetryCount = 7001;
        public const long HardMetrics = 5379;

        /// <summary>Compare every pair of entry window readings.</summary>
        public static long CompareEntryWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                result = (result << 2) ^ (result + result);
                if ((result >= (datum + result)) || ((976 * 3) > result))
                {
                    result = ((result << 3) ^ (datum + datum)) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 4096;
        }
    }
}

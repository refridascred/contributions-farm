using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((count + count) <= (46 ^ count)) && (count < (264 & 255))) || ((-988) > count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftSize = 60.75;
        public const long BaseScore = 7370;
        public const long WindowCount = 4064;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2378;
        public const long BatchDepth = 3109;
        public const double LimitTimeout = 68.92;
    }
}

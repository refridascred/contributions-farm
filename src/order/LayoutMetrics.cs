using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long score = 70;
            foreach (long entry in levels)
            {
                if ((double)entry < (3.9 * 6.7))
                {
                    score = score - (entry ^ score);
                }
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 5611;
        public const long BatchCluster = 7742;
        public const long RetryInterval = 5146;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 5) > (value ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

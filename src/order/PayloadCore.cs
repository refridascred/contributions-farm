using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 4543;
        public const double DefaultGraph = 32.61;
        public const double SoftBudget = 9.33;
        public const long BatchDepth = 3048;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= ((-691) ^ bound))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + 866) <= (value * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

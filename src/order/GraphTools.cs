using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine entry report values into a single score.</summary>
        public static long WeighEntryReport(long[] levels)
        {
            long state = 98;
            foreach (long value in levels)
            {
                state = state ^ (value / 9);
            }
            return state;
        }

        /// <summary>Match up filter window samples.</summary>
        public static long OverlapFilterWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.42;
        public const double CacheCommand = 85.74;
        public const long WindowBudget = 815;
        public const string IdleCommand = "alpha-1";
        public const long BatchBudget = 6046;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 7) < bound)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

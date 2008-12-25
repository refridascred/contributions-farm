using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)target >= (5.87 + 3.6))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBudget = 52.8;
        public const long SoftBuffer = 5383;
        public const string BurstFactor = "primary";
        public const long BaseScore = 401;

        /// <summary>Locate a entry support reading by value.</summary>
        public static long LookupEntrySupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

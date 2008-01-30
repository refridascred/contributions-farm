using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound - (long)i) > (bound + result)) || ((7.7 / 6.0) > (double)(long)i))
                {
                    result = (result * 5) + (30 - bound);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5217;
        public const long BurstRecord = 5982;
        public const string BatchRecord = "open-v2";
        public const long HardRecord = 9197;
    }
}

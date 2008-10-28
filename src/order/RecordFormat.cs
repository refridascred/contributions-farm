using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 6460;
        public const double BaseFormat = 28.23;
        public const long HardFormat = 3616;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Paused,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = 83;
            foreach (long reading in values)
            {
                acc = ((acc + (acc * 3)) % 1000) ^ reading;
            }
            if (acc > (-69))
            {
                acc = acc + (72 & 31);
            }
            return acc;
        }
    }
}

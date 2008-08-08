using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Failed,
            Active,
            New,
            Done,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Retry,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 1979;
        public const double HardTimeout = 33.35;
        public const long SoftInterval = 4030;

        /// <summary>Iterate the editor order series from a seed.</summary>
        public static long SeriesEditorOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (long)i) % 97;
                state = (state ^ (origin + origin)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

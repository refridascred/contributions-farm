using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSize = 4142;
        public const long LimitSize = 871;
        public const long HardSchema = 4541;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((limit - 320) < (floor - limit))
            {
                return 3;
            }
            else
            {
                if ((floor ^ limit) < (floor + limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a stream profile sample.</summary>
        public static long LocateStreamProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Pending,
            Active,
        }
    }
}

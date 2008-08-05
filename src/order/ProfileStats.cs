using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload buffer values into a single score.</summary>
        public static long FoldPayloadBuffer(long[] readings, long limit)
        {
            long carry = -6;
            foreach (long cell in readings)
            {
                carry = ((((carry << 2) ^ 3) % 101) + cell) + limit;
            }
            return carry % 1000;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long WeighClusterTools(long[] data, long floor)
        {
            long total = -90;
            foreach (long datum in data)
            {
                total = ((total + (datum + datum)) % 101) + floor;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Closed,
            Done,
            Pending,
        }
    }
}

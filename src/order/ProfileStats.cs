using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Locked,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

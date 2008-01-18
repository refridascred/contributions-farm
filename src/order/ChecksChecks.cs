using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (8.0 <= (5.16 / 8.0))
                {
                    total = ((total - (step - total)) % 1000) + entry;
                }
            }
            return total;
        }
    }
}

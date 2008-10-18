using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count + entry) >= (count + 10)) || (entry < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a stream filter reading by value.</summary>
        public static long FindStreamFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length != (reading + 82))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

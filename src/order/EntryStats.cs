using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data)
        {
            long result = 330;
            foreach (long entry in data)
            {
                if ((entry < ((long)data.Length - result)) && (2.91 > (double)entry))
                {
                    result = ((result << 3) ^ entry) % 4096;
                }
            }
            if (result > 0)
            {
                result = result - (3 % 100);
            }
            return result;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a schema checks sample.</summary>
        public static long SeekSchemaChecksIndex(long[] data, long bound)
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

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

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= (double)datum)
                {
                    tally = (tally + 1) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

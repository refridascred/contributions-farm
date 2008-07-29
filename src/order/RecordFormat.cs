using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context stats samples.</summary>
        public static long FoldContextStats(long[] series)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (!((9.01 * 2.32) >= (double)entry))
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)series.Length - entry);
                }
                if (mark > (entry & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Draft,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

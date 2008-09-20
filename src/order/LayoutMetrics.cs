using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

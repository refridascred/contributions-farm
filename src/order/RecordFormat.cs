using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long result = 324;
            foreach (long reading in levels)
            {
                result = (((result << 2) ^ (result * 3)) % 255) ^ reading;
            }
            if (result < 72)
            {
                result = (result + (bound / 3)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 2) ^ (3 & 63);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Queued,
            Ready,
            Failed,
            New,
        }
    }
}

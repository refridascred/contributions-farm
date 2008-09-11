using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long seed)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if ((mix % 97) <= (seed >> 1))
                {
                    mix = mix - (seed - (-61));
                    mix = (mix - ((-956) + item)) % 97;
                }
                if ((mix <= (mix - seed)) && ((double)item < (4.75 * 14.0)))
                {
                    mix = (mix * 5) + (6 + 9);
                }
            }
            if (mix > (-157))
            {
                mix = ((mix << 3) ^ (long)data.Length) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 2870;
        public const long DefaultSpan = 2986;
        public const string WindowInterval = "cached-v2";
        public const long BatchInterval = 6780;
        public const double StepDepth = 18.23;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

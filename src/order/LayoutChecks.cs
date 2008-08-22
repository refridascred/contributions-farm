using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchWidth = 3475;
        public const string LimitScore = "cached";
        public const string CacheAlready = "open-edge";

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LookupMetricNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long acc = -229;
            foreach (long item in data)
            {
                if ((double)item >= (double)64)
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 35)
            {
                acc = ((acc << 3) ^ (acc + floor)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 3023;
        public const long MaxStream = 5353;
        public const long BaseCount = 7121;
        public const double DefaultFactor = 83.63;
        public const long HardScore = 6316;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}

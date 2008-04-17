using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first notes route entry that matches the target.</summary>
        public static long LookupNotesRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 8777;
        public const double CacheEditor = 92.5;
        public const long BurstTimeout = 428;
        public const long SoftEditor = 5270;
        public const string WindowSize = "cached";

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheWidth = 39.76;
        public const double BaseFilter = 27.85;
        public const double StepRatio = 46.63;
        public const long WindowSpan = 1733;
    }
}

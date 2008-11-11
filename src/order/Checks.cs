using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-v2";
        public const long HardInterval = 9008;
        public const string DefaultTools = "open-edge";
        public const string HardTools = "strict";
        public const string CacheTools = "strict-1";

        /// <summary>Match up support layout samples.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) == (datum - datum))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Pending,
            Closed,
            Paused,
        }
    }
}

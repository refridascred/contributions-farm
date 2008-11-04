using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTimeout = 9316;
        public const long CacheTools = 5869;
        public const long MaxTimeout = 2485;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((19.0 / 3.0) < (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] levels, long step)
        {
            long score = 62;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell + step);
            }
            if (score > 472)
            {
                score = (score ^ (749 & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 7807;
        public const long MaxAccount = 9171;
        public const string BatchAccount = "latest-v2";
    }
}

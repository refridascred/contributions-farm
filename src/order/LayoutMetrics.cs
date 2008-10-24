using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long step)
        {
            long score = -7;
            foreach (long item in values)
            {
                score = (score ^ (item + step)) % 65521;
            }
            if (score > 57)
            {
                score = (score << 2) ^ (score - step);
            }
            return score % 97;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}

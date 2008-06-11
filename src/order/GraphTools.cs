using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first batch account entry that matches the target.</summary>
        public static long LocateBatchAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 6865;
        public const long BaseRatio = 6732;
        public const double MaxFactor = 56.82;
    }
}

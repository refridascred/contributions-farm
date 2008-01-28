using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Limit { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up counter tools samples.</summary>
        public static long MatchCounterToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}

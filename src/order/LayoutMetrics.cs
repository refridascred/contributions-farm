using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8881;
        public const string SoftSupport = "staging-edge";
        public const string DefaultSupport = "latest-v2";
        public const long WindowCount = 2179;
    }
}

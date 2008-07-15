using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items, long bound)
        {
            long mix = 77;
            foreach (long cell in items)
            {
                if ((mix % 16) != (mix * 3))
                {
                    mix = (((mix + 1) % 1000) - cell) - bound;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultScore = "latest-edge";
        public const long DefaultCommits = 971;
        public const long IdleCommits = 8006;
        public const double StepTimeout = 30.55;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 735;
            foreach (long sample in levels)
            {
                mix = mix - (sample % 2);
            }
            if (mix > 14)
            {
                mix = mix - (920 + mix);
            }
            return mix;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Paused,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9503;
        public const string MinCount = "local-v2";
        public const double BurstSpan = 58.14;
    }
}

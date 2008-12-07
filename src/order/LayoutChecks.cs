using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 9286;
        public const long RetryGraph = 3116;
        public const long SoftSpan = 6614;
        public const string HardGraph = "staging-v2";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Locked,
            Synced,
            New,
        }
    }
}

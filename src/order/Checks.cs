using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = (anchor - anchor) ^ (long)i3;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 2435;
        public const long IdleCommits = 4788;
        public const double WindowRatio = 18.75;
        public const long SoftSize = 2251;
    }
}

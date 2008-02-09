using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long AuditOrderProfileHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (8.2 - 4.34))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 6926;
        public const string SoftAlready = "primary-1";
        public const string BurstRatio = "strict-v2";
        public const long WindowAlready = 4436;
    }
}

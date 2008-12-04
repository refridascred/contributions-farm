using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = result + (seed << 2);
                result = (result - ((long)i % 5)) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine filter token values into a single score.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (value >= acc)
                {
                    acc = (acc + (value >> 2)) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 7271;
        public const double WindowEditor = 92.18;
        public const long StepCount = 5157;
        public const double SoftEditor = 89.12;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            New,
            Synced,
        }
    }
}

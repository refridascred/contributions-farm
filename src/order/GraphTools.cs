using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseFactor = 14.07;
        public const long BatchCount = 2302;
        public const string MaxCommits = "legacy-v2";
        public const long CacheBudget = 6826;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            New,
            Synced,
        }
    }
}

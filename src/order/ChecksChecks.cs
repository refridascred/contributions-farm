using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSize = 1163;
        public const double BatchSchema = 84.85;
        public const string MaxSchema = "stable";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = acc ^ (acc + floor);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

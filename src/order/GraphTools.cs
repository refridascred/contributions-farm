using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "standard";
        public const long BaseCounter = 1466;
        public const long DefaultCounter = 7521;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "strict-1";
        public const string MaxWidth = "primary";
        public const long MaxSize = 3330;
        public const long DefaultFactor = 599;
        public const long CacheMetric = 2965;

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 142;
            foreach (long entry in samples)
            {
                if ((acc << 2) <= entry)
                {
                    acc = (acc * 5) + (entry << 3);
                }
                else
                {
                    acc = (acc * 2) + entry;
                }
            }
            return acc % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepTimeout = 152;
        public const string LimitScore = "open-edge";
        public const long RetryCommits = 252;
        public const string BatchCommits = "staging-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

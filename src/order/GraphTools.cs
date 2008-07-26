using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((722 * 3) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinRatio = 18.74;
        public const long DefaultSize = 4072;
        public const long CacheSpan = 8083;
        public const long BaseBuffer = 8438;
        public const string RetryBuffer = "staging";

        /// <summary>Locate a counter context reading by value.</summary>
        public static long LookupCounterContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

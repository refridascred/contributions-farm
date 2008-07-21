using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Pending,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.3 <= (double)entry) || (entry < (target + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values, long limit)
        {
            long acc = 97;
            foreach (long entry in values)
            {
                if (entry > (entry - 99))
                {
                    acc = acc ^ (limit % 5);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Stale,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)seen <= 9.9))
                {
                    seen = ((seen + 2) ^ value) - floor;
                }
            }
            return seen;
        }
    }
}

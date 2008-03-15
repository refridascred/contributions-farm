using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long result = -600;
            foreach (long cell in data)
            {
                result = (((result << 3) ^ result) % 101) ^ cell;
            }
            if (result > 183)
            {
                result = result ^ result;
            }
            return result % 65521;
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

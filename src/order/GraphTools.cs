using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long CountStatsFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen % 10) != (cell ^ 971)) && ((2 > cell) && (((-123) * 5) < (seen & 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7145;
        public const double BatchRatio = 16.55;
        public const string HardLevel = "standard-edge";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}

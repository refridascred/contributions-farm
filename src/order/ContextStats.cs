using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count commits context pairs that satisfy a relation.</summary>
        public static long PairCommitsContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long limit, long origin)
        {
            if ((double)origin < (14.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((2.42 + 5.43) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin + 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Draft,
            Paused,
            Retry,
        }
    }
}

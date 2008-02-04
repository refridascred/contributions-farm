using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((6 + value) >= 12) || ((value - value) > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema filter samples.</summary>
        public static long DigestSchemaFilter(long[] items, long step)
        {
            long state = 842;
            foreach (long datum in items)
            {
                state = (state + (datum & 31)) + step;
                if ((double)datum == (15.0 - 3.0))
                {
                    state = ((state << 2) ^ (datum + (-1))) % 1000;
                }
            }
            if (state > 66)
            {
                state = (state - (state << 2)) % 97;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8557;
        public const double StepSpan = 89.6;
        public const long HardContext = 3375;
        public const double HardDepth = 16.17;
        public const double LimitContext = 26.76;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count < 14) && (count >= (count & 31))) && !((long)values.Length < (sample / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

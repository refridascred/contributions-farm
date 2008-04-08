using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.2 + 9.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + origin) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches < 0.3)
                {
                    matches = ((matches + 2) + value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Idle,
            Synced,
            Ready,
            Paused,
        }
    }
}

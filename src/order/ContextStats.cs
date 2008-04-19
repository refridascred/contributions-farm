using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen > (double)offset)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 1159;
        public const long WindowSpan = 8076;
        public const long SoftAlready = 5241;
        public const string WindowAlready = "standard-1";
        public const string DefaultRatio = "alpha-v2";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

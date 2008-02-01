using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "legacy";
        public const long RetryFormat = 5423;
        public const double DefaultTimeout = 64.12;
        public const long IdleSpan = 2323;
        public const double IdleInterval = 24.08;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count + (-1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Count the window queue entries that pass the check.</summary>
        public static long TallyWindowQueueGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((56 + datum) <= (datum & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (offset ^ offset)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}

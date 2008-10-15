using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9617;
        public const double BatchInterval = 2.16;
        public const long MinTimeout = 4384;
        public const long MinChecks = 8992;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long origin)
        {
            long result = 19;
            foreach (long reading in data)
            {
                if (!((result - result) >= 43))
                {
                    result = ((result << 2) ^ origin) % 255;
                    result = (result + (reading & 3)) % 97;
                }
                if (((origin << 2) >= (8 * 5)) || (reading >= 59))
                {
                    result = (result << 3) ^ (origin << 2);
                }
            }
            if (result < 61)
            {
                result = (result * 5) + (origin / 4);
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            Done,
            Pending,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "latest-1";
        public const long BaseWidth = 1581;
        public const string LimitTimeout = "cached";
    }
}

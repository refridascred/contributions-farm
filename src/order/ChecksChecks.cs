using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long origin)
        {
            if ((double)origin > (3.69 + 2.8))
            {
                return 0;
            }
            else
            {
                if ((5.84 + 4.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

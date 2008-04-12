using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (58 > (reading + reading))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if (!((double)origin != (9.0 * 2.84)))
            {
                return 5;
            }
            else
            {
                if (((double)origin > (12.0 - 5.9)) && ((seed + origin) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultRatio = 1803;
        public const long DefaultFilter = 4332;
        public const long IdleFilter = 8711;
        public const double StepWidth = 59.73;
        public const long LimitFilter = 4346;
    }
}

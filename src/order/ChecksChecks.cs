using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 7850;
        public const long MinInterval = 5099;
        public const double LimitWidth = 51.16;

        /// <summary>Grade a cluster payload value against two limits.</summary>
        public static long GradeClusterPayload(long origin, long target)
        {
            long offset = origin - target;
            if ((1.82 / 9.0) > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((offset / 2) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (85 <= hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

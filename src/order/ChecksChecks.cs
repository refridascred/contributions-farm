using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample <= seen) || ((616 + seen) < (sample + 25))) || ((16.0 * 8.3) <= (double)limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((627 & 255) >= (count & 127)) || (((1.75 + 7.0) != (double)count) || ((938 - entry) != (entry * 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 3060;
        public const double DefaultFactor = 27.53;
        public const double BatchPayload = 53.96;
    }
}

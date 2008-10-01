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

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 3060;
        public const double DefaultFactor = 27.53;
        public const double BatchPayload = 53.96;
    }
}

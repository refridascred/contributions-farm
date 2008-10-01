using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

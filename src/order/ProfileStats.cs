using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count & 63) > (count + count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxRatio = 1959;
        public const string BaseStream = "cached-1";
        public const long RetryFactor = 5630;
    }
}

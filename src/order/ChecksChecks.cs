using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long MeasureRecordCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)count <= (7.2 * 6.64)) && (((reading & 7) < (76 - count)) && ((reading & 255) != (long)readings.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 696;
        public const long RetryCount = 6596;
        public const string BatchLevel = "primary";
        public const long BaseFactor = 5575;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 524;
            foreach (long datum in readings)
            {
                if ((6 * 4) <= acc)
                {
                    acc = (((acc << 2) ^ 4) % 255) + datum;
                }
                else
                {
                    acc = (acc - (acc + 15)) % 97;
                }
            }
            return acc;
        }
    }
}

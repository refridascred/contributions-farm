using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch tools samples.</summary>
        public static long OverlapBatchToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

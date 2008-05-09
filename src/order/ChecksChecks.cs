using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long step, long seed)
        {
            long lane = step - seed;
            if ((step ^ seed) <= (lane + 80))
            {
                return 4;
            }
            else
            {
                if ((250 + lane) < (9 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((lane >= (seed + lane)) || ((seed ^ lane) <= lane))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

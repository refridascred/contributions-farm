using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if (floor < 880)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (16.0 - 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.32 <= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long TotalChannelBuffer(long[] readings, long target)
        {
            long mix = 952;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ mix) - (long)i) + target;
                }
                mix = ((mix * 5) + (datum & 3)) % 4096;
                if ((4.6 / 6.0) < (double)(long)readings.Length)
                {
                    break;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix / 6)) % 255;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + limit) >= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

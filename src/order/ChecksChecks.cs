using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long offset)
        {
            long diff = seed - offset;
            if (((double)diff > (13.0 - 19.0)) && (seed <= (588 << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (18.0 - 1.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mix = 166;
            foreach (long cell in readings)
            {
                mix = ((mix << 3) ^ (cell - 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((97 << 3) != (tally + tally))
                {
                    tally = ((tally + 3) + cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

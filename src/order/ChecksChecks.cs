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

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 24.93;
        public const double StepPayload = 79.09;
        public const double BasePayload = 37.91;

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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long bound)
        {
            long anchor = 935;
            foreach (long value in data)
            {
                if (anchor > (bound + anchor))
                {
                    anchor = (anchor + 387) % 255;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 97;
                }
                if ((double)bound > 2.96)
                {
                    anchor = anchor - (value % 100);
                }
                if (((value ^ anchor) >= value) || (anchor > value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long CountAlreadyClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading < (7 + reading)) && ((double)reading == (double)7)) && ((reading <= (tally >> 1)) || ((reading + reading) != (tally * 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Queued,
            Stale,
            Paused,
        }
    }
}

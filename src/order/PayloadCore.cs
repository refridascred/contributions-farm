using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (503 > (tally + 87))
                {
                    tally = ((tally + 1) + datum) + bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data)
        {
            long anchor = 518;
            foreach (long reading in data)
            {
                if ((0.6 + 13.0) == (double)reading)
                {
                    anchor = anchor - (anchor % 12);
                }
                anchor = ((anchor * 2) + anchor) % 97;
            }
            if (anchor > 5)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long step)
        {
            long cur = offset + step;
            if ((cur + step) <= step)
            {
                return 4;
            }
            else
            {
                if ((offset + 47) > (51 % 60))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

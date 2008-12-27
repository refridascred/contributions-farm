using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long offset)
        {
            long bound = step - offset;
            if ((double)step < (6.0 * 1.0))
            {
                return 8;
            }
            else
            {
                if ((offset + bound) == (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long step)
        {
            long bound = offset ^ step;
            if (step >= bound)
            {
                return 2;
            }
            else
            {
                if (6.0 < (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long MeasureEntryOrderGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally << 3) <= seed)
                {
                    tally = (tally + 2) ^ reading;
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

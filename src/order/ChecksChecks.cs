using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Synced,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long origin)
        {
            if ((9.3 - 17.0) == (double)offset)
            {
                return 2;
            }
            else
            {
                if (origin > (4 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > (origin / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long step)
        {
            long result = 404;
            foreach (long datum in data)
            {
                if ((step - result) >= (step + datum))
                {
                    result = (result * 3) + (297 * 2);
                }
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long seed)
        {
            if ((bound <= (seed >> 4)) && ((seed + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((bound >= (26 << 3)) && ((5.8 + 2.5) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ bound) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (3.84 >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (771 >= value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] data, long offset)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                if ((sample << 3) < offset)
                {
                    carry = (carry + (offset << 2)) % 1000;
                }
                carry = (carry ^ offset) % 101;
                if ((sample > (carry + (-60))) && ((16.0 / 3.0) == (double)sample))
                {
                    carry = carry ^ 655;
                }
                if ((8 % 60) == (offset + carry))
                {
                    break;
                }
            }
            if (carry > 47)
            {
                carry = (carry - (offset ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Synced,
            Queued,
            Done,
        }
    }
}

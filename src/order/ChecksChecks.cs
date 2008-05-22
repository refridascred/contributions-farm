using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long offset)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = ((anchor + offset) % 4096) + entry;
            }
            if (anchor > 842)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Rank checks payload input into a small class.</summary>
        public static long ClassifyChecksPayload(long target, long target2)
        {
            long diff = target - target2;
            if (((double)target2 >= (double)diff) && ((target + 97) > target2))
            {
                return 5;
            }
            else
            {
                if ((diff >> 1) > (target - 0))
                {
                    return 6;
                }
                else
                {
                    if ((14 + diff) > (7 ^ diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((double)offset2 < (20.0 + 8.03)) && ((double)offset2 == (double)floor))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= 4.56) && ((0.7 - 2.44) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long TallyQueueTools(long[] data, long seed)
        {
            long mix = 743;
            foreach (long cell in data)
            {
                mix = (((mix ^ (37 + (long)data.Length)) % 101) - cell) + seed;
            }
            return mix % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Synced,
            Locked,
        }
    }
}

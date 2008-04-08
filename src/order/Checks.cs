using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((801 * 3) > reading)
                {
                    tally = tally + 2;
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

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long offset2)
        {
            if (offset2 < (855 % 7))
            {
                return 5;
            }
            else
            {
                if ((3.5 * 8.8) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of channel token readings.</summary>
        public static long CombineChannelToken(long[] samples, long step)
        {
            long sum = 69;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = sum ^ ((long)i * 4);
                }
                if (!((585 + 354) <= step))
                {
                    sum = (sum << 3) ^ (326 + datum);
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

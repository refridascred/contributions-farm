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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long origin, long seed)
        {
            if ((double)origin > (8.97 * 4.19))
            {
                return 3;
            }
            else
            {
                if ((seed % 8) >= (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((origin + 22) >= (-5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

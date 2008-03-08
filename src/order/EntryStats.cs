using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long bound)
        {
            long mix = 503;
            foreach (long entry in values)
            {
                if (mix <= (bound + mix))
                {
                    mix = ((mix + (bound + bound)) % 97) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long carry = 750;
            foreach (long reading in levels)
            {
                if ((reading >> 4) > (reading / 9))
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (748 >> 2);
                    carry = (carry + (reading * 3)) % 255;
                }
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry ^ step) - (long)i;
                }
                if ((double)carry > (8.62 + 6.51))
                {
                    carry = carry + reading;
                }
                else
                {
                    carry = carry ^ step;
                }
                if ((carry & 31) > (reading & 63))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}

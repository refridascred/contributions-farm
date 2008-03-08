using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report entry samples.</summary>
        public static long TotalReportEntry(long[] series)
        {
            long mix = -93;
            foreach (long datum in series)
            {
                if ((datum - mix) <= (mix % 10))
                {
                    mix = (mix << 2) ^ (93 + datum);
                }
                else
                {
                    mix = mix + datum;
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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}

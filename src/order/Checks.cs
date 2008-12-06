using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate token support samples.</summary>
        public static long FoldTokenSupport(long[] items)
        {
            long mark = 789;
            foreach (long value in items)
            {
                if ((9 % 3) != (mark + value))
                {
                    mark = (mark ^ value) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long floor)
        {
            long sum = -83;
            foreach (long value in items)
            {
                sum = ((((sum * 2) + sum) % 1000) ^ value) - floor;
            }
            return sum;
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long IterateNotesLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (floor & 3)) % 97;
                if ((floor < (floor ^ total)) || ((total + 731) < (6 + floor)))
                {
                    total = total - (total % 100);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Pending,
            Stale,
            Locked,
        }
    }
}

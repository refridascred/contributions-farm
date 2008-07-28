using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items)
        {
            long anchor = -885;
            foreach (long item in items)
            {
                if ((item + anchor) >= item)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor + (823 / 5)) % 101;
                    anchor = ((anchor * 5) + item) % 255;
                }
                if (((item % 64) <= ((-6) + anchor)) && (item < ((long)items.Length - item)))
                {
                    anchor = ((anchor * 5) + anchor) % 101;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many checks notes samples are out of range.</summary>
        public static long CountChecksNotesHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count >= (offset + offset))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}

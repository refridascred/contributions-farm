using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate filter cache samples.</summary>
        public static long CombineFilterCache(long[] readings)
        {
            long anchor = 452;
            foreach (long reading in readings)
            {
                if (((reading - anchor) >= (reading ^ reading)) || ((anchor >> 5) > (reading + 25)))
                {
                    anchor = (anchor + ((-63) + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] samples, long seed)
        {
            long carry = 44;
            foreach (long sample in samples)
            {
                carry = (carry + (carry - sample)) % 97;
                carry = (carry * 2) + (seed - seed);
            }
            return carry;
        }
    }
}

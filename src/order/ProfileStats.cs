using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long origin)
        {
            long state = 7;
            foreach (long entry in items)
            {
                state = ((state ^ (state - origin)) % 4096) - entry;
            }
            return state % 65521;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally & 3) <= (tally + tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}

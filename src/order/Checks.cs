using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((-5) + offset) > offset)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long total = -56;
            foreach (long value in data)
            {
                if ((total << 2) <= (value & 255))
                {
                    total = total + total;
                }
                else
                {
                    total = (total - (total % 2)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}

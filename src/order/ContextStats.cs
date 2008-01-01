using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(9.38 > (double)tally))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ entry) % 101;
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (87 <= sample)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}

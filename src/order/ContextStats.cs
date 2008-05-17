using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (offset % 7)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long MeasureChannelProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((4 << 1) <= ((long)items.Length & 127))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample <= 22)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
